namespace A21_Ex02_Gaya_206105371_Vladimir_317303071
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
            ErrorMessage = null;
            CountPlaces = 0;
            CheckedInLocation = string.Empty;
            LocationCheckedInDictionary = null;
            UrlListOfPhotos = null;
        }

        public AppUser AppUser { get; set; }

        public List<string> UrlListOfPhotos { get; set; }

        public Dictionary<string, string> LocationCheckedInDictionary { get; set; }

        public int IndexInListUrlImage { get; set; }

        public string ErrorMessage { get; set; }

        public int CountPlaces { get; set; }

        public string CheckedInLocation { get; set; }

        public void LogIn()
        {
            AppUser = new AppUser(k_AppId);
        }

        public void LogOut()
        {
            FacebookService.Logout();
            AppUser.LoggedInUser = null;
        }

        public void AddTolistBoxLocation(string i_LocationType)
        {
            LocationCheckedInDictionary = new Dictionary<string, string>();
            CheckedInLocation = string.Empty;
            CountPlaces = 0;

            if (string.Equals(i_LocationType, "Country"))
            {
                addCheckedInCountriesToList();
            }
            else if (string.Equals(i_LocationType, "City"))
            {
                addCheckedInCitiesToList();
            }
            else if (string.Equals(i_LocationType, "Street"))
            {
                addCheckedInStreetsToList();
            }
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
            foreach (Album album in AppUser.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.Place != null)
                    {
                        if (string.Equals(photo.Place.Location.Country, i_ChosenLocation))
                        {
                            UrlListOfPhotos.Add(photo.ThumbURL);
                        }
                        else if (string.Equals(photo.Place.Location.City, i_ChosenLocation))
                        {
                            UrlListOfPhotos.Add(photo.ThumbURL);
                        }
                        else if (string.Equals(photo.Place.Location.Street, i_ChosenLocation))
                        {
                            UrlListOfPhotos.Add(photo.ThumbURL);
                        }
                    }
                }
            }
        }

        private void addCheckedInStreetsToList()
        {
            ErrorMessage = "No pictures with street location";
            foreach (Checkin checkin in AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place.Location.Street != null)
                {
                    CheckedInLocation = checkin.Place.Location.Street;
                    addListBoxLocations(checkin, CheckedInLocation, ErrorMessage);
                    CountPlaces++;
                }
            }
        }

        private void addCheckedInCitiesToList()
        {
            ErrorMessage = "No pictures with city location";
            foreach (Checkin checkin in AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place.Location.City != null) // TODO:: check if null
                {
                    CheckedInLocation = checkin.Place.Location.City;
                    addListBoxLocations(checkin, CheckedInLocation, ErrorMessage);
                    CountPlaces++;
                }
            }
        }

        private void addCheckedInCountriesToList()
        {
            ErrorMessage = "No pictures with country location";
            foreach (Checkin checkin in AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place.Location.Country != null)
                {
                    CheckedInLocation = checkin.Place.Location.Country;
                    addListBoxLocations(checkin, CheckedInLocation, ErrorMessage);
                    CountPlaces++;
                }
            }
        }

        private void addListBoxLocations(Checkin i_Checkin, string i_CheckedInLocation, string i_ErrorMessage)
        {
            if (LocationCheckedInDictionary.ContainsKey(i_CheckedInLocation) == false)
            {
                addToChekedInDictionary(i_CheckedInLocation);
            }
        }

        private void addToChekedInDictionary(string i_LocationString)
        {
            LocationCheckedInDictionary.Add(i_LocationString, i_LocationString);
        }
    }
}