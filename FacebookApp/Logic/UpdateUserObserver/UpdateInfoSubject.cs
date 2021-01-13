namespace FacebookApp
{
    using System.Collections.Generic;

    public abstract class UpdateInfoSubject
    {
        private List<UpdateInfoObserver> m_Observers = new List<UpdateInfoObserver>();

        public void Attach(UpdateInfoObserver observer)
        {
            m_Observers.Add(observer);
        }

        public void Detach(UpdateInfoObserver observer)
        {
            m_Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (UpdateInfoObserver o in m_Observers)
            {
                o.Update();
            }
        }
    }
}
