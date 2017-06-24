﻿using System;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    public class TestInterfaces
    {
        public static MainMenu GenerateMenus()
        {
            MainMenu mainMenu = new MainMenu("Application");
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
                countSpacesMethod();
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
                countCharsMethod();
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
                Console.WriteLine(DateTime.Now.ToShortDateString());
            }
        }

        private static void countSpacesMethod()
        {
            Console.WriteLine("Hit me with a sentence!");
            string sentence = Console.ReadLine();
            int counterOfSpaces = 0;

            if (sentence.Length == 0)
            {
                Console.WriteLine("There are no spaces in this sentence");
            }
            else
            {
                for (int i = 0; i < sentence.Length - 1; i++)
                {
                    if (sentence[i] == ' ')
                    {
                        counterOfSpaces++;
                    }
                }

                Console.WriteLine(string.Format("There are {0} spaces in that sentence", counterOfSpaces));
            }
        }

        private static void countCharsMethod()
        {
            Console.WriteLine("Hit me with a sentence!");
            string sentence = Console.ReadLine();
            int counterOfChars = 0;

            if (sentence.Length == 0)
            {
                Console.WriteLine("There are no letters in this sentence");
            }
            else
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (Char.IsLetter(sentence[i]))
                    {
                        counterOfChars++;
                    }
                }

                Console.WriteLine(string.Format("There are {0} letters in that sentence", counterOfChars));
            }
        }
    }
}
