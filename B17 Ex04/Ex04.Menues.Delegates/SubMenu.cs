using System;
using System.Collections.Generic;

namespace Ex04.Menues.Delegates
{
    class SubMenu : Menu
    {
		public SubMenu()
			: base()
		{
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

		public SubMenu(string i_Title, Nullable<int> i_Level, SelectedEventHandler i_ActionDelegate)
            : base(i_Title, i_Level, i_ActionDelegate)
		{
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

		public SubMenu(string i_Title, Nullable<int> i_Level, List<MenuItem> i_Items, SelectedEventHandler i_ActionDelegate)
            : base(i_Title, i_Level, i_Items, i_ActionDelegate)
		{
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}
    }
}
