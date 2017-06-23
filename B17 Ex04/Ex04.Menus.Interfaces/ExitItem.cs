using System;

namespace Ex04.Menus.Interfaces
{
    class ExitItem : IMenuItem
    {
        public string GetTitle()
        {
            return "Exit";
        }

        public void OnSelected()
        {
            Environment.Exit(0);
        }
    }
}
