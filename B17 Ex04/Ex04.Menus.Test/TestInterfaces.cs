using System;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    public class TestInterfaces
    {
        public static void Main()
        {

        }

        public class ActionsAndInfo : SubMenu
        {

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

        public class Actions : SubMenu
        {

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

        public class ShowDateTime : SubMenu
        {

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
