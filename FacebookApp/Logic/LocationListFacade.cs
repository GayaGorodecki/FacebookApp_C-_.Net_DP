namespace FacebookApp
{
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;

    public class LocationListFacade
    {
        public LocationListFacade(AppUser i_AppUser)
        {
            CheckedInLocation = string.Empty;
            ErrorMessage = null;
            CountPlaces = 0;
            LocationCheckedInDictionary = null;
            AppUser = i_AppUser;
        }

        public Dictionary<string, string> LocationCheckedInDictionary { get; set; }

        public int CountPlaces { get; set; }

        public string CheckedInLocation { get; set; }

        public AppUser AppUser { get; set; }

        public string ErrorMessage { get; set; }

        public string LocationType { get; set; }

        public void AddTolistBoxLocation(string i_LocationType)
        {
            LocationCheckedInDictionary = new Dictionary<string, string>();
            CheckedInLocation = string.Empty;
            CountPlaces = 0;
            LocationType = i_LocationType;

            Location location = new LocationAdapter(this, LocationType);
            location.AddCheckInToList();
        }

        public void AddListBoxLocations(Checkin i_Checkin)
        {
            if (LocationCheckedInDictionary.ContainsKey(CheckedInLocation) == false)
            {
                addToChekedInDictionary(CheckedInLocation);
            }
        }

        private void addToChekedInDictionary(string i_LocationString)
        {
            LocationCheckedInDictionary.Add(LocationType, i_LocationString);
        }
    }
}
