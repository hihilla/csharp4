namespace Ex04.Menues.Delegates
{
    abstract class MenuItem
    {
        internal string m_Title;
        internal int m_SerialNumber;

        public delegate void ActionDelegate();
        public event ActionDelegate ActionEvent;

        public void doAction()
        {
            ActionEvent.Invoke();
        }
    }
}
