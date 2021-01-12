namespace FacebookApp
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    public class Database : Observer
    {
        private static Database m_Instance;
        private List<UpdatedUser> m_UpdatedUsers;
        private static string s_Path = Directory.GetCurrentDirectory() + "\\UpdatedUsers.xml";
        private UpdatedUser m_UserToUpdate;

        public static Database getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new Database();
                Stream stream = new FileStream(s_Path, FileMode.OpenOrCreate);
                stream.Close();
            }

            return m_Instance;
        }

        public ConcreteSubject Subject { get; set; }

        public void AddNewUser(UpdatedUser i_UpdatedUser)
        {
            m_UpdatedUsers = LoadUserData();
            this.m_UpdatedUsers.Add(i_UpdatedUser);
            SaveUserData();
        }

        public override void Update()
        {
            m_UserToUpdate = Subject.SubjectState;

            m_UpdatedUsers = LoadUserData();

            foreach (UpdatedUser user in m_UpdatedUsers)
            {
                if (user.Id == m_UserToUpdate.Id)
                {
                    user.FirstName = m_UserToUpdate.FirstName;
                    user.LastName = m_UserToUpdate.LastName;
                    user.Birthday = m_UserToUpdate.Birthday;
                    user.Email = m_UserToUpdate.Email;
                }
            }

            SaveUserData();
        }

        public bool IsUserExist(string i_Id)
        {
            m_UpdatedUsers = LoadUserData();
            bool userExists = false;
            foreach (UpdatedUser user in m_UpdatedUsers)
            {
                if (user.Id == i_Id)
                {
                    userExists = true;
                }
            }

            return userExists;
        }

        public UpdatedUser GetUserInfo(string i_Id)
        {
            m_UpdatedUsers = LoadUserData();
            foreach (UpdatedUser userInfo in m_UpdatedUsers)
            {
                if (userInfo.Id == i_Id)
                {
                    return userInfo;
                }
            }

            return null;
        }

        public void SaveUserData()
        {
            using (Stream stream = new FileStream(s_Path, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<UpdatedUser>));
                serializer.Serialize(stream, this.m_UpdatedUsers);
            }
        }

        public static List<UpdatedUser> LoadUserData()
        {
            List<UpdatedUser> userinfo = new List<UpdatedUser>();

            if (File.Exists(s_Path))
            {
                using (Stream stream = new FileStream(s_Path, FileMode.Open))
                {
                    if (stream.Length != 0)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<UpdatedUser>));
                        userinfo = serializer.Deserialize(stream) as List<UpdatedUser>;
                    }
                }
            }

            return userinfo;
        }
    }
}