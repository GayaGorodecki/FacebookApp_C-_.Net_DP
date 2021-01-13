namespace FacebookApp
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class UpdateInfoTool : Form
    {
        private UpdatedUser m_UpdatedUser;
        Database db = Database.getInstance();
        ConcreteUpdatedUser m_ObserversToUpdate = new ConcreteUpdatedUser();

        public UpdateInfoTool(User i_UserToUpdate)
        {
            InitializeComponent();

            setUserToUpdate(i_UserToUpdate);
            setUserOriginalInfo();

            db.Subject = m_ObserversToUpdate;
            m_ObserversToUpdate.Attach(db);
        }

        private void setUserToUpdate(User i_UserToUpdate)
        {
            if (db.IsUserExist(i_UserToUpdate.Id))
            {
                m_UpdatedUser = db.GetUserInfo(i_UserToUpdate.Id);
            }
            else
            {
                m_UpdatedUser = new UpdatedUser(i_UserToUpdate);
                db.AddNewUser(m_UpdatedUser);
            }
        }

        private void setUserOriginalInfo()
        {
            dateTimePickerBirthday.Text = m_UpdatedUser.Birthday;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if ((textBoxFirstName.Text != string.Empty) && (textBoxFirstName.Text != "Update First Name"))
            {
                m_UpdatedUser.FirstName = textBoxFirstName.Text;
            }

            if ((textBoxLastName.Text != string.Empty) && (textBoxLastName.Text != "Update Last Name"))
            {
                m_UpdatedUser.LastName = textBoxLastName.Text;
            }

            if (dateTimePickerBirthday.Text != string.Empty)
            {
                m_UpdatedUser.Birthday = dateTimePickerBirthday.Text;
            }

            if ((textBoxEmail.Text != string.Empty) && (textBoxEmail.Text != "Update Email"))
            {
                m_UpdatedUser.Email = textBoxEmail.Text;
            }

            m_ObserversToUpdate.SubjectState = m_UpdatedUser;
            m_ObserversToUpdate.Notify();

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