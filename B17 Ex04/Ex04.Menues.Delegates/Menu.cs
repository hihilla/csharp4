using System;
using System.Collections.Generic;

namespace Ex04.Menues.Delegates
{
    public abstract class Menu : MenuItem
    {
        internal readonly List<MenuItem> r_MenuItems;
        internal static readonly string sr_Divider = "================";
        internal static readonly int sr_ExitOption = 0;
        internal static readonly string sr_SubMenuClassName = "Ex04.Menues.Delegates.SubMenu";
        internal static readonly string sr_MainMenuClassName = "Ex04.Menues.Delegates.MainMenu";

        internal Menu() : base()
        {
            this.r_MenuItems = new List<MenuItem>();
        }

        internal Menu(string i_Title, Nullable<int> i_Level)
            : base(i_Title, i_Level)
        {
            this.r_MenuItems = new List<MenuItem>();
            this.Selected += this.ShowMenu;
        }

        internal Menu(string i_Title, Nullable<int> i_Level, List<MenuItem> i_Items)
            : base(i_Title, i_Level)
        {
            this.r_MenuItems = new List<MenuItem>(i_Items);
            this.Selected += this.ShowMenu;
        }

        public void AddMenuItem(MenuItem i_Item, int i_Level)
        {
            r_MenuItems.Insert(i_Level, i_Item);
        }

        internal void printItems()
        {
            for (int i = 1; i < r_MenuItems.Count; i++)
            {
                MenuItem item = r_MenuItems[i];
                string title = string.Format("{0}. {1}", i, item.Title);
                Console.WriteLine(title);
            }

            MenuItem exitItem = r_MenuItems[0];
            string exitTitle = string.Format("{0}. {1}", 0, exitItem.Title);
            Console.WriteLine(exitTitle);
        }

        virtual internal string getMenuTitle()
        {
            return string.Format("{0}. {1}", r_SerialNumber, m_Title);
        }

        public void ShowMenu()
        {
            int chosenAction;
            do
            {
                Console.Clear();
                Console.WriteLine(getMenuTitle());
                Console.WriteLine(sr_Divider);
                this.printItems();
                chosenAction = this.usersChosenAction();
                Console.Clear();
                r_MenuItems[chosenAction].OnSelected();
                if (chosenAction != sr_ExitOption
                    && r_MenuItems[chosenAction].GetType().ToString() != sr_SubMenuClassName
                    && r_MenuItems[chosenAction].GetType().ToString() != sr_MainMenuClassName)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (chosenAction != sr_ExitOption);
        }

        internal int usersChosenAction()
        {
            int action;
            string exitAction = r_SerialNumber.HasValue ? "Back" : "Exit";
            string message = string.Format("Please enter your choise ({0}-{1} or {2} to {3})",
                                           1, r_MenuItems.Count - 1, sr_ExitOption, exitAction);
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out action)
                     || (action < 0)
                     || (action > r_MenuItems.Count));

            return action;
        }
    }
}
