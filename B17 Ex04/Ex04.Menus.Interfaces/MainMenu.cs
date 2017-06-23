using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    class MainMenu : Menu
    {
        public MainMenu()
            : base()
        {
            this.AddMenuItem(new ExitItem(), sr_ExitOption);
        }

        public MainMenu(string i_Title, Nullable<int> i_Level)
            : base(i_Title, i_Level)
        {
            this.AddMenuItem(new ExitItem(), sr_ExitOption);
        }

        public MainMenu(string i_Title, Nullable<int> i_Level, List<IMenuItem> i_Items)
            : base(i_Title, i_Level, i_Items)
        {
            this.AddMenuItem(new ExitItem(), sr_ExitOption);
        }
    }
}
