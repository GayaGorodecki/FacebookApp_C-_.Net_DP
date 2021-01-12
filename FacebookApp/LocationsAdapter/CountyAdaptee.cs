namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public class CountyAdaptee
    {
        public void AddCheckedInCountriesToList(LocationListFacade i_LocationListFacade)
        {
            i_LocationListFacade.ErrorMessage = "No pictures with country location";
            foreach (Checkin checkin in i_LocationListFacade.AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place != null)
                {
                    if (checkin.Place.Location.Country != null)
                    {
                        i_LocationListFacade.CheckedInLocation = checkin.Place.Location.Country;
                        i_LocationListFacade.AddListBoxLocations(checkin);
                        i_LocationListFacade.CountPlaces++;
                    }
                }
            }
        }
    }
}
