namespace Ex04.Menues.Delegates
{
    class MenuItem
    {
        internal string m_Title;
        internal int m_SerialNumber;

        public delegate void ActionDelegate();
        public event ActionDelegate ActionEventHendler;

        public MenuItem()
        {
            ActionEventHendler = null;
        }
        public MenuItem(string i_Title, int i_SerialNumber, ActionDelegate i_ActionDelegate)
        {
            this.m_Title = i_Title;
            this.m_SerialNumber = i_SerialNumber;
            this.ActionEventHendler += i_ActionDelegate;
        }
        public string Title
        {
            get
            {
                return m_Title;
            }
        }

        public void OnSelected()
        {
            if (ActionEventHendler == null) {
                
            } else {
                ActionEventHendler.Invoke();
            }
        }
    }
}
