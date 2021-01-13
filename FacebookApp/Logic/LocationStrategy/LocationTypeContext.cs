namespace FacebookApp
{
    class LocationTypeContext
    {
        private LocationListStrategy m_LocationListStrategy;
        private LocationListFacade m_LocationListFacade;

        public LocationTypeContext(LocationListStrategy strategy, LocationListFacade i_LocationListFacade)
        {
            m_LocationListStrategy = strategy;
            m_LocationListFacade = i_LocationListFacade;
        }

        public void ContextInterface()
        {
            m_LocationListStrategy.AddCheckedInLocationToList(m_LocationListFacade);
        }
    }
}