namespace FacebookApp
{
    public class ConcreteSubject : Subject
    {
        private UpdatedUser m_SubjectState;

        public UpdatedUser SubjectState
        {
            get { return m_SubjectState; }
            set { m_SubjectState = value; }
        }
    }
}
