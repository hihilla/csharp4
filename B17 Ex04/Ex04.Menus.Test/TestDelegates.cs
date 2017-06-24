using System;
using Ex04.Menues.Delegates;
namespace Ex04.Menus.Test
{
    public class TestDelegates
    {
        public static MainMenu GenerateMenus()
        {
            MainMenu mainMenu = new MainMenu();
            SubMenu actionsAndInfo = new SubMenu("Actions And Info", 1);
            SubMenu actions = new SubMenu("Actions", 2);
            SubMenu showDateTime = new SubMenu("Show Date/Time", 2);
            MenuItem displayVersion = new MenuItem("Display Version", 1, DisplayVersionMethod);
            MenuItem countSpaces = new MenuItem("Count Spaces", 1, null);
            MenuItem charsCount = new MenuItem("Chars Count", 2, null);
            MenuItem showTime = new MenuItem("Show Time", 1, ShowTime);
            MenuItem showDate = new MenuItem("Show Date", 2, ShowDate);


            mainMenu.AddMenuItem(actionsAndInfo, 1);
            mainMenu.AddMenuItem(showDateTime, 2);

            actionsAndInfo.AddMenuItem(displayVersion, 1);
            actionsAndInfo.AddMenuItem(actions, 2);

            actions.AddMenuItem(countSpaces, 1);
            actions.AddMenuItem(charsCount, 2);

            showDateTime.AddMenuItem(showTime, 1);
            showDateTime.AddMenuItem(showDate, 2);

            return mainMenu;
        }

        public static void DisplayVersionMethod()
        {
            Console.WriteLine("App Version: 17.2.4.0");
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
