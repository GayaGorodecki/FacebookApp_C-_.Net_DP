namespace A21_Ex02_Gaya_206105371_Vladimir_317303071
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class Database
    {
        private static Database m_Instance;
        private List<UserInfo> m_UpdatedUsers;

        public static Database getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new Database();
                Stream stream = new FileStream(@"D:UpdatedUsers.xml", FileMode.OpenOrCreate);
                stream.Close();
            }

            return m_Instance;
        }

        public void AddNewUser(UserInfo i_UpdatedUser)
        {
            m_UpdatedUsers = LoadUserData();
            this.m_UpdatedUsers.Add(i_UpdatedUser);
            SaveUserData();
        }

        public void UpdateUser(UserInfo i_UpdatedUser)
        {
            m_UpdatedUsers = LoadUserData();

            foreach (UserInfo user in m_UpdatedUsers)
            {
                if (user.Id == i_UpdatedUser.Id)
                {
                    user.FirstName = i_UpdatedUser.FirstName;
                    user.LastName = i_UpdatedUser.LastName;
                    user.Birthday = i_UpdatedUser.Birthday;
                    user.Email = i_UpdatedUser.Email;
                }
            }

            SaveUserData();
        }

        public bool IsUserExist(string i_Id)
        {
            m_UpdatedUsers = LoadUserData();
            foreach (UserInfo user in m_UpdatedUsers)
            {
                if (user.Id == i_Id)
                {
                    return true;
                }
            }

            return false;
        }

        public UserInfo GetUserInfo(string i_Id)
        {
            m_UpdatedUsers = LoadUserData();
            foreach (UserInfo userInfo in m_UpdatedUsers)
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
            using (Stream stream = new FileStream(@"D:UpdatedUsers.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<UserInfo>));
                serializer.Serialize(stream, this.m_UpdatedUsers);
            }
        }

        public static List<UserInfo> LoadUserData()
        {
            List<UserInfo> userinfo = new List<UserInfo>();

            if (File.Exists(@"D:UpdatedUsers.xml")) // TODO:: change file location?
            {
                using (Stream stream = new FileStream(@"D:UpdatedUsers.xml", FileMode.Open))
                {
                    if (stream.Length != 0)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<UserInfo>));
                        userinfo = serializer.Deserialize(stream) as List<UserInfo>;
                    }
                }
            }

            return userinfo;
        }
    }
}