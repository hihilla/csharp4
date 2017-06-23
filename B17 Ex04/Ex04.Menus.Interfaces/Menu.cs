using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    abstract class Menu
    {
        internal string m_Title = "";
        internal readonly List<IMenuItem> r_MenuItems;
        internal readonly int r_CurrentLevel;

        internal Menu()
        {

        }

        public void ShowMenu()
        {
            //TODO
        }

    }
}
