namespace FacebookApp
{
    using System.Collections.Generic;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public class AppLogic
    {
        private const string k_AppId = "2882855308604428";

        public AppLogic()
        {
            IndexInListUrlImage = 0;
            UrlListOfPhotos = null;
        }

        public LocationListFacade LocationListFacade { get; set; }

        public AppUser AppUser { get; set; }

        public List<string> UrlListOfPhotos { get; set; }

        public int IndexInListUrlImage { get; set; }

        public void LogIn()
        {
            AppUser = new AppUser(k_AppId);
            LocationListFacade = new LocationListFacade(AppUser);
        }

        public void LogOut()
        {
            FacebookService.Logout();
            AppUser.LoggedInUser = null;
        }

        public void UrlListIndexManger()
        {
            if (IndexInListUrlImage < UrlListOfPhotos.Count - 1)
            {
                IndexInListUrlImage++;
            }
            else
            {
                IndexInListUrlImage = 0;
            }
        }

        public void AddPhotosUrlToList(string i_ChosenLocation)
        {
            foreach (Checkin checkin in AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place != null && checkin.PictureURL != null)
                {
                    if (string.Equals(checkin.Place.Location.Country, i_ChosenLocation)
                        || string.Equals(checkin.Place.Location.City, i_ChosenLocation)
                        || string.Equals(checkin.Place.Location.Street, i_ChosenLocation))
                    {
                        UrlListOfPhotos.Add(checkin.PictureURL);
                    }
                }
            }
        }
    }
}