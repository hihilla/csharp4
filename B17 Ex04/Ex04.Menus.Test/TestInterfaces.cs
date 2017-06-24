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
        }

        public class CharsCount : IMenuItem
        {
            public string GetTitle()
            {
                return "Chars Count";
            }

            public void OnSelected()
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
