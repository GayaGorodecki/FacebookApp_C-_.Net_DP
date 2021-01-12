namespace A21_Ex02_Gaya_206105371_Vladimir_317303071
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class UpdateInfoTool : Form
    {
        private User m_UserToUpdate;
        private UserInfo m_UserInfoToUpdate; // TODO :: change names
        Database db = Database.getInstance();

        public UpdateInfoTool(User i_UserToUpdate)
        {
            InitializeComponent();
            m_UserToUpdate = i_UserToUpdate;

            if (db.IsUserExist(m_UserToUpdate.Id))
            {
                m_UserInfoToUpdate = db.GetUserInfo(m_UserToUpdate.Id);
            }
            else
            {
                m_UserInfoToUpdate = new UserInfo(m_UserToUpdate);
                db.AddNewUser(m_UserInfoToUpdate);
            }

            dateTimePickerBirthday.Text = m_UserInfoToUpdate.Birthday;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if ((textBoxFirstName.Text != string.Empty) && (textBoxFirstName.Text != "Update First Name"))
            {
                m_UserInfoToUpdate.FirstName = textBoxFirstName.Text;
            }

            if ((textBoxLastName.Text != string.Empty) && (textBoxLastName.Text != "Update Last Name"))
            {
                m_UserInfoToUpdate.LastName = textBoxLastName.Text;
            }

            if (dateTimePickerBirthday.Text != string.Empty)
            {
                m_UserInfoToUpdate.Birthday = dateTimePickerBirthday.Text;
            }

            if ((textBoxEmail.Text != string.Empty) && (textBoxEmail.Text != "Update Email"))
            {
                m_UserInfoToUpdate.Email = textBoxEmail.Text;
            }

            db.UpdateUser(m_UserInfoToUpdate);

            MessageBox.Show("Your Information Changed!");
            this.Close();
        }

        private void textBoxFirstName_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxFirstName.Text = string.Empty;
        }

        private void textBoxLastName_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxLastName.Text = string.Empty;
        }

        private void textBoxEmail_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxEmail.Text = string.Empty;
        }
    }
}