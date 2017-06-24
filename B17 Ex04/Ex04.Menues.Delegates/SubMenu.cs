﻿using System;
using System.Collections.Generic;

namespace Ex04.Menues.Delegates
{
    public class SubMenu : Menu
    {
		public SubMenu()
			: base()
		{
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

        public SubMenu(string i_Title, Nullable<int> i_Level)
            : base(i_Title, i_Level)
		{
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

        public SubMenu(string i_Title, Nullable<int> i_Level, List<MenuItem> i_Items)
            : base(i_Title, i_Level, i_Items)
		{
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}
    }
}
