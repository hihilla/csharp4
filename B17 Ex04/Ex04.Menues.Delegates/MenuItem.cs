namespace Ex04.Menues.Delegates
{
    class MenuItem
    {
        internal string m_Title;
        internal int m_SerialNumber;

        public delegate void SelectedEventHandler();
        public event SelectedEventHandler Selected;

        public MenuItem()
        {
            Selected = null;
        }
        public MenuItem(string i_Title, int i_SerialNumber, SelectedEventHandler i_ActionDelegate)
        {
            this.m_Title = i_Title;
            this.m_SerialNumber = i_SerialNumber;
            this.Selected += i_ActionDelegate;
        }
        public string Title
        {
            get
            {
                return m_Title;
            }
        }

        virtual public void OnSelected()
        {
            if (Selected == null) {
                
            } else {
                Selected.Invoke();
            }
        }
    }
}
