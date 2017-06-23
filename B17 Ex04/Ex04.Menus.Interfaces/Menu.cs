using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    abstract class Menu
    {
        internal string m_Title = "";
        internal readonly List<IMenuItem> r_MenuItems;
        internal readonly int r_CurrentLevel;

        internal Menu(string i_Title, int i_Level)
        {
            this.m_Title = i_Title;
            this.r_CurrentLevel = i_Level;
            this.r_MenuItems = new List<IMenuItem>();
        }

        internal Menu(string i_Title, int i_Level, List<IMenuItem> i_Items)
        {
            this.m_Title = i_Title;
            this.r_CurrentLevel = i_Level;
            this.r_MenuItems = new List<IMenuItem>(i_Items);
        }

        public void AddMenuItem(IMenuItem i_Item, int i_Level)
        {
            r_MenuItems.Insert(i_Level, i_Item);

        }

        public void ShowMenu()
        {
            //TODO
        }

    }
}
