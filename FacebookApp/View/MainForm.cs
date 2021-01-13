namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private const int TO_PROFILE_LAYOUT = 0;
        private const int TO_LOGIN_LAYOUT = 1;
        private AppLogic m_AppLogic;

        Database db = Database.getInstance();
        UpdatedUser m_UpdatedUser;

        public MainForm()
        {
            m_AppLogic = new AppLogic();
            InitializeComponent();
        }

        internal void fetchUserInfo()
        {
            fetchUnchangedInfo();
            m_UpdatedUser = db.GetUserInfo(m_AppLogic.AppUser.LoggedInUser.Id);
            if (m_UpdatedUser != null)
            {
                fetchUpdatedUserInfo();
            }
            else
            {
                fetchOriginalUserInfo();
            }

            new Thread(addDataSourceToListBoxPosts).Start();
        }

        private void fetchOriginalUserInfo()
        {
            this.Invoke(new Action(() => this.Text = m_AppLogic.AppUser.LoggedInUser.FirstName + "'s Profile"));
            textBoxFirstName.Invoke(new Action(() => textBoxFirstName.Text = m_AppLogic.AppUser.LoggedInUser.FirstName));
            textBoxLastName.Invoke(new Action(() => textBoxLastName.Text = m_AppLogic.AppUser.LoggedInUser.LastName));
            textBoxBirthday.Invoke(new Action(() => textBoxBirthday.Text = m_AppLogic.AppUser.LoggedInUser.Birthday));
            textBoxEmail.Invoke(new Action(() => textBoxEmail.Text = m_AppLogic.AppUser.LoggedInUser.Email));
        }

        private void fetchUnchangedInfo()
        {
            switchLayoutPanel(TO_PROFILE_LAYOUT);
            profilePictureBox.Invoke(new Action(() => profilePictureBox.Visible = true));
            profilePictureBox.Invoke(new Action(() => profilePictureBox.LoadAsync(m_AppLogic.AppUser.LoggedInUser.PictureNormalURL)));
            textBoxGender.Invoke(new Action(() => textBoxGender.Text = m_AppLogic.AppUser.LoggedInUser.Gender.ToString()));
        }

        private void fetchUpdatedUserInfo()
        {
            this.Invoke(new Action(() => this.Text = m_UpdatedUser.FirstName + "'s Profile"));
            textBoxFirstName.Invoke(new Action(() => textBoxFirstName.Text = m_UpdatedUser.FirstName));
            textBoxLastName.Invoke(new Action(() => textBoxLastName.Text = m_UpdatedUser.LastName));
            textBoxBirthday.Invoke(new Action(() => textBoxBirthday.Text = m_UpdatedUser.Birthday));
            textBoxEmail.Invoke(new Action(() => textBoxEmail.Text = m_UpdatedUser.Email));
        }

        private void switchLayoutPanel(int i_LayoutToSwitch)
        {
            if (i_LayoutToSwitch == TO_PROFILE_LAYOUT)
            {
                flowLayoutPanel.Invoke(new Action(() => flowLayoutPanel.Visible = false));
                buttonLogout.Invoke(new Action(() => buttonLogout.Visible = true));
                tabControlUpdateInfo.Invoke(new Action(() => tabControlUpdateInfo.Visible = true));
            }
            else if (i_LayoutToSwitch == TO_LOGIN_LAYOUT)
            {
                tabControlUpdateInfo.Invoke(new Action(() => tabControlUpdateInfo.Visible = false));
                flowLayoutPanel.Invoke(new Action(() => flowLayoutPanel.Visible = true));
                buttonLogout.Invoke(new Action(() => buttonLogout.Visible = false));
            }
        }

        private void clearFeed()
        {
            profilePictureBox.Visible = false;
            textBoxBirthday.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
            textBoxGender.Text = string.Empty;
            this.Text = "Facebook - Login";
            switchLayoutPanel(TO_LOGIN_LAYOUT);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_AppLogic.LogOut();
            clearFeed();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_AppLogic.LogIn();
            if (!string.IsNullOrEmpty(m_AppLogic.AppUser.LoginResult.AccessToken))
            {
                m_AppLogic.AppUser.LoggedInUser = m_AppLogic.AppUser.LoginResult.LoggedInUser;
                new Thread(fetchUserInfo).Start();
            }
            else
            {
                MessageBox.Show(m_AppLogic.AppUser.LoginResult.ErrorMessage);
            }
        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buttonPause.Text == "Resume")
            {
                buttonPause.Text = "Pause";
            }

            timerSlideShow.Stop();
            fetchPhotoByLocation(comboBoxLocationType.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_AppLogic.AppUser.LoggedInUser != null)
            {
                m_AppLogic.LogOut();
                clearFeed();
            }
        }

        private void fetchPhotoByLocation(string i_LocationType)
        {
            listBoxLocations.Items.Clear();

            m_AppLogic.LocationListFacade.AddTolistBoxLocation(i_LocationType);

            if (m_AppLogic.LocationListFacade.CountPlaces == 0)
            {
                MessageBox.Show(m_AppLogic.LocationListFacade.ErrorMessage);
            }

            addLocationToListBox(i_LocationType);
        }

        private void addLocationToListBox(string i_CheckedInLocation)
        {
            foreach (KeyValuePair<string, string> keyValue in m_AppLogic.LocationListFacade.LocationCheckedInDictionary)
            {
                listBoxLocations.Items.Add(keyValue.Value);
            }
        }

        private void listBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenLocationFromList = ((ListBox)sender).SelectedItem.ToString();
            string locationType = comboBoxLocationType.SelectedItem.ToString();
            displaySelectedLocation(chosenLocationFromList);
        }

        private void displaySelectedLocation(string i_ChosenLocationFromList)
        {
            m_AppLogic.UrlListOfPhotos = new List<string>();
            m_AppLogic.AddPhotosUrlToList(i_ChosenLocationFromList);
            bool isUrlEmpty = m_AppLogic.UrlListOfPhotos.Count > 0 ? false : true;
            startOrStopSlidePictureShow(isUrlEmpty);
        }

        private void startOrStopSlidePictureShow(bool i_IsUrlEmpty)
        {
            if (i_IsUrlEmpty)
            {
                timerSlideShow.Stop();
            }
            else
            {
                m_AppLogic.IndexInListUrlImage = 0;
                timerSlideShow.Start();
            }
        }

        private void timerSlideShow_Tick(object sender, EventArgs e)
        {
            nextPhoto();
        }

        private void nextPhoto()
        {
            pictureBoxLocation.LoadAsync(m_AppLogic.UrlListOfPhotos[m_AppLogic.IndexInListUrlImage]);
            m_AppLogic.UrlListIndexManger();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (comboBoxLocationType.SelectedItem != null && listBoxLocations.SelectedItem != null)
            {
                changeStatusOfPauseButton();
            }
            else
            {
                MessageBox.Show("You Must Choose Location");
            }
        }

        private void changeStatusOfPauseButton()
        {
            timerSlideShow.Enabled = !timerSlideShow.Enabled;
            buttonPause.Text = timerSlideShow.Enabled ? "Pause" : "Resume";
        }

        private void buttonCropAndSaveImg_Click(object sender, EventArgs e)
        {
            if (m_AppLogic.UrlListOfPhotos != null)
            {
                int imageIndexFix = 0;
                if (m_AppLogic.IndexInListUrlImage != 0)
                {
                    imageIndexFix = 1;
                }

                SnippingTool snippingToolForm = new SnippingTool(m_AppLogic.UrlListOfPhotos[m_AppLogic.IndexInListUrlImage - imageIndexFix]);
                snippingToolForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Choose Picture To Crop and Save");
            }
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            UpdateInfoTool updateInfo = new UpdateInfoTool(m_AppLogic.AppUser.LoggedInUser);
            updateInfo.ShowDialog();

            fetchUserInfo();
        }

        private void addDataSourceToListBoxPosts()
        {
            postBindingSource.DataSource = m_AppLogic.AppUser.LoggedInUser.Posts;
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Visible = true));
            panelPostsInfo.Invoke(new Action(() => panelPostsInfo.Visible = true));
        }
    }
}