using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    abstract class Menu
    {
        private string m_Title = "";
        private readonly List<IMenuItem> r_MenuItems;
        private readonly int r_CurrentLevel;

        public void ShowMenu()
        {
            //TODO
        }

    }
}
