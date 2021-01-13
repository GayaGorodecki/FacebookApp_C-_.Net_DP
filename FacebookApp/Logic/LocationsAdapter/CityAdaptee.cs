namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public class CityAdaptee : LocationListStrategy
    {
        public override void AddCheckedInLocationToList(LocationListFacade i_LocationListFacade)
        {
            i_LocationListFacade.ErrorMessage = "No pictures with city location";
            foreach (Checkin checkin in i_LocationListFacade.AppUser.LoggedInUser.Checkins)
            {
                if (checkin.Place != null)
                {
                    if (checkin.Place.Location.City != null)
                    {
                        i_LocationListFacade.CheckedInLocation = checkin.Place.Location.City;
                        i_LocationListFacade.AddListBoxLocations(checkin);
                        i_LocationListFacade.CountPlaces++;
                    }
                }
            }
        }
    }
}