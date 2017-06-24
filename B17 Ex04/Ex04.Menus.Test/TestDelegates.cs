using System;
using Ex04.Menus.Delegates;
namespace Ex04.Menus.Test
{
    public class TestDelegates
    {
        public static MainMenu GenerateMenus()
        {
            MainMenu mainMenu = new MainMenu("Application");
            SubMenu actionsAndInfo = new SubMenu("Actions And Info", 1);
            SubMenu actions = new SubMenu("Actions", 2);
            SubMenu showDateTime = new SubMenu("Show Date/Time", 2);
            MenuItem displayVersion = new MenuItem("Display Version", 1, displayVersionMethod);
            MenuItem countSpaces = new MenuItem("Count Spaces", 1, countSpacesMethod);
            MenuItem charsCount = new MenuItem("Chars Count", 2, countCharsMethod);
            MenuItem showTime = new MenuItem("Show Time", 1, showTimeMethod);
            MenuItem showDate = new MenuItem("Show Date", 2, showDateMethod);


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

        private static void displayVersionMethod()
        {
            Console.WriteLine("App Version: 17.2.4.0");
        }

        private static void showTimeMethod()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        private static void showDateMethod()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
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
