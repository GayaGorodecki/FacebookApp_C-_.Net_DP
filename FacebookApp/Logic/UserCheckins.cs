namespace FacebookApp
{
    using System.Collections;
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;

    public class UserCheckins
    {
        public static AppUser m_AppUser;
        public static string m_ChosenLocation;
        public FacebookObjectCollection<Checkin> m_Checkins;

        public UserCheckins(AppUser i_AppUser, string i_ChosenLocation)
        {
            m_Checkins = i_AppUser.LoggedInUser.Checkins;
            m_ChosenLocation = i_ChosenLocation;
        }

        public IEnumerator<Checkin> GetEnumerator()
        {
            return new userCheckinsIterator(this);
        }

        public class userCheckinsIterator : IEnumerator<Checkin>
        {
            UserCheckins m_UserCheckins;
            int index = -1;

            public userCheckinsIterator(UserCheckins i_UserCheckins)
            {
                m_UserCheckins = i_UserCheckins;
            }

            public void Reset()
            {
                index = -1;
            }

            public Checkin Current
            {
                get
                {
                    return m_UserCheckins.m_Checkins[index];
                }

            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
                Reset();
            }

            public bool MoveNext()
            {
                index++;
                while (index < m_UserCheckins.m_Checkins.Count)
                {
                    if (placeAndUrlNotNull())
                    {
                        if (matchAdreses())
                        {
                            break;
                        }
                    }

                    index++;
                }

                return index != m_UserCheckins.m_Checkins.Count;
            }

            private bool placeAndUrlNotNull()
            {
                bool placeAndUrlNotNull = false;
                if (m_UserCheckins.m_Checkins[index].Place != null && m_UserCheckins.m_Checkins[index].PictureURL != null)
                {
                    placeAndUrlNotNull = true;
                }

                return placeAndUrlNotNull;
            }

            private bool matchAdreses()
            {
                bool matchAdreses = false;
                if (string.Equals(m_UserCheckins.m_Checkins[index].Place.Location.Country, m_ChosenLocation)
                 || string.Equals(m_UserCheckins.m_Checkins[index].Place.Location.City, m_ChosenLocation)
                 || string.Equals(m_UserCheckins.m_Checkins[index].Place.Location.Street, m_ChosenLocation))
                {
                    matchAdreses = true;
                }

                return matchAdreses;
            }
        }
    }
}