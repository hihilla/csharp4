using System;

namespace Ex04.Menus.Interfaces
{
    class BackItem : IMenuItem
    {
        public string GetTitle()
        {
            return "Back";
        }

        public void OnSelected() { }
    }
}
