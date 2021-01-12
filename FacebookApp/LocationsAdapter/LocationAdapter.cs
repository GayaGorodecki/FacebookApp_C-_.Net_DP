namespace FacebookApp
{
    public class LocationAdapter : Location
    {
        private StreetAdaptee _StreetAdaptee;
        private CityAdaptee _CityAdaptee;
        private CountyAdaptee _CountryAdaptee;
        private LocationListFacade m_LocationListFacade;
        private string m_LocationType;

        public LocationAdapter(LocationListFacade i_LocationListFacade, string i_LocationType)
        {
            this.m_LocationType = i_LocationType;
            this.m_LocationListFacade = i_LocationListFacade;
        }

        public override void AddCheckInToList()
        {
            if (string.Equals(m_LocationType, "Country"))
            {
                _CountryAdaptee = new CountyAdaptee();
                _CountryAdaptee.AddCheckedInCountriesToList(m_LocationListFacade);
            }
            else if (string.Equals(m_LocationType, "City"))
            {
                _CityAdaptee = new CityAdaptee();
                _CityAdaptee.AddCheckedInCitiesToList(m_LocationListFacade);
            }
            else if (string.Equals(m_LocationType, "Street"))
            {
                _StreetAdaptee = new StreetAdaptee();
                _StreetAdaptee.AddCheckedInStreetsToList(m_LocationListFacade);
            }
        }
    }
}
