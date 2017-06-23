using System.Collections.Generic;

namespace Ex04.Menues.Delegates
{
    class MainMenu : Menu
    {
		public MainMenu()
			: base()
		{
			this.AddMenuItem(new ExitItem(), sr_ExitOption);
		}

		public MainMenu(string i_Title)
			: base(i_Title, null)
		{
			this.AddMenuItem(new ExitItem(), sr_ExitOption);
		}

		public MainMenu(string i_Title, List<MenuItem> i_Items)
			: base(i_Title, null, i_Items)
		{
			this.AddMenuItem(new ExitItem(), sr_ExitOption);
		}
    }
}
