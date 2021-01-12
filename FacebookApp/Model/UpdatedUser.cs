﻿namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public class UpdatedUser
    {
        public UpdatedUser() { }

        public UpdatedUser(User m_UserToUpdate)
        {
            FirstName = m_UserToUpdate.FirstName;
            LastName = m_UserToUpdate.LastName;
            Birthday = m_UserToUpdate.Birthday;
            Email = m_UserToUpdate.Email;
            Id = m_UserToUpdate.Id;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public string Id { get; set; }
    }
}