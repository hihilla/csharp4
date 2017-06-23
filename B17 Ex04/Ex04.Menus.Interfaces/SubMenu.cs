using System;

namespace Ex04.Menus.Interfaces
{
    class SubMenu : Menu, IMenuItem
    {
        public string GetTitle()
        {
            return m_Title;
        }

        public void OnSelected()
        {
            throw new NotImplementedException();
        }
    }
}
