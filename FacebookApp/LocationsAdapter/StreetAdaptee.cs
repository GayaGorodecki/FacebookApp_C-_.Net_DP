namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public class StreetAdaptee
    {
        public void AddCheckedInStreetsToList(LocationListFacade i_LocationListFacade)
        {
            i_LocationListFacade.ErrorMessage = "No pictures with street location";
            foreach (Checkin checkin in i_LocationListFacade.AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place != null)
                {
                    if (checkin.Place.Location.Street != null)
                    {
                        i_LocationListFacade.CheckedInLocation = checkin.Place.Location.Street;
                        i_LocationListFacade.AddListBoxLocations(checkin);
                        i_LocationListFacade.CountPlaces += 1;
                    }
                }
            }
        }
    }
}
