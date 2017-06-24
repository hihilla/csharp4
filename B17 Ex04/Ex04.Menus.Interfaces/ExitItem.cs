using System;

namespace Ex04.Menus.Interfaces
{
    public class ExitItem : IMenuItem
    {
        public string GetTitle()
        {
            return "Exit";
        }

        public void OnSelected() { }
    }
}
