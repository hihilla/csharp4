using System;

namespace Ex04.Menues.Delegates
{
    public class MenuItem
    {
        internal string m_Title;
        internal readonly int r_SerialNumber;

        public delegate void SelectedEventHandler();
        public event SelectedEventHandler Selected;

        public MenuItem()
        {
            Selected = null;
        }

        public MenuItem(string i_Title, int i_SerialNumber)
        {
            this.m_Title = i_Title;
            this.r_SerialNumber = i_SerialNumber;
            this.Selected += null;
        }

        public MenuItem(string i_Title, int i_SerialNumber, SelectedEventHandler i_EventHandler)
        {
            this.m_Title = i_Title;
            this.r_SerialNumber = i_SerialNumber;
            this.Selected += i_EventHandler;
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
            if (Selected == null)
            {
                Console.WriteLine("No action to do...");
            }
            else
            {
                Selected.Invoke();
            }
        }
    }
}
