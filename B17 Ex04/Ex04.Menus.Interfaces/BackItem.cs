using System;

namespace Ex04.Menus.Interfaces
{
    public class BackItem : IMenuItem
    {
        public string GetTitle()
        {
            return "Back";
        }

        public void OnSelected() { }
    }
}
