using System;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    public class TestInterfaces
    {
        public static MainMenu GenerateMenus()
        {
            MainMenu mainMenu = new MainMenu();
            SubMenu actionsAndInfo = new SubMenu("Actions And Info", 1);
            SubMenu actions = new SubMenu("Actions", 2);
            SubMenu showDateTime = new SubMenu("Show Date/Time", 2);

            mainMenu.AddMenuItem(actionsAndInfo, 1);
            mainMenu.AddMenuItem(showDateTime, 2);

            actionsAndInfo.AddMenuItem(new DisplayVersion(), 1);
            actionsAndInfo.AddMenuItem(actions, 2);

            actions.AddMenuItem(new CountSpaces(), 1);
            actions.AddMenuItem(new CharsCount(), 2);

            showDateTime.AddMenuItem(new ShowTime(), 1);
            showDateTime.AddMenuItem(new ShowDate(), 2);

            return mainMenu;
        }

        public class DisplayVersion : IMenuItem
        {
            public string GetTitle()
            {
                return "Display Version";
            }

            public void OnSelected()
            {
                Console.WriteLine("App Version: 17.2.4.0");
            }
        }

        public class CountSpaces : IMenuItem
        {
            public string GetTitle()
            {
                return "Count Spaces";
            }

            public void OnSelected()
            {
                // TODO
            }
        }

        public class CharsCount : IMenuItem
        {
            public string GetTitle()
            {
                return "Chars Count";
            }

            public void OnSelected()
            {
                // TODO
            }
        }

        public class ShowTime : IMenuItem
        {
            public string GetTitle()
            {
                return "Show Time";
            }

            public void OnSelected()
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
                Console.WriteLine(DateTime.Now.ToShortTimeString());
            }
        }

        public class ShowDate : IMenuItem
        {
            public string GetTitle()
            {
                return "Show Date";
            }

            public void OnSelected()
            {
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                Console.WriteLine(DateTime.Now.ToShortDateString());
            }
        }

    }
}
