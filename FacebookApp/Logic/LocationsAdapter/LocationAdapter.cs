namespace FacebookApp
{
    public class LocationAdapter : Location
    {
        private LocationTypeContext m_LocationTypeContext;
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
                m_LocationTypeContext = new LocationTypeContext(new CountyAdaptee(), m_LocationListFacade);
            }
            else if (string.Equals(m_LocationType, "City"))
            {
                m_LocationTypeContext = new LocationTypeContext(new CityAdaptee(), m_LocationListFacade);
            }
            else if (string.Equals(m_LocationType, "Street"))
            {
                m_LocationTypeContext = new LocationTypeContext(new StreetAdaptee(), m_LocationListFacade);
            }

            m_LocationTypeContext.ContextInterface();
        }
    }
}