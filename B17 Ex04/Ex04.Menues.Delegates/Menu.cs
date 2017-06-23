using System;
using System.Collections.Generic;

namespace Ex04.Menues.Delegates
{
    abstract class Menu : MenuItem
    {
        internal readonly List<MenuItem> r_MenuItems;
        internal static readonly string sr_Divider = "================";
        internal static readonly int sr_ExitOption = 0;

        internal Menu() : base()
        {
            this.r_MenuItems = new List<MenuItem>();
        }

        internal Menu(string i_Title, Nullable<int> i_Level, SelectedEventHandler i_EventHandler) 
            : base (i_Title, i_Level, i_EventHandler)
        {
            this.r_MenuItems = new List<MenuItem>();
        }

        internal Menu(string i_Title, Nullable<int> i_Level, List<MenuItem> i_Items, SelectedEventHandler i_EventHandler) 
            : base (i_Title, i_Level, i_EventHandler)
        {
            this.r_MenuItems = new List<MenuItem>(i_Items);
        }

        public override void OnSelected()
        {
            ShowMenu();
        }

        public void AddMenuItem(MenuItem i_Item, int i_Level)
        {
            r_MenuItems.Insert(i_Level, i_Item);
        }

        internal void printItems()
        {
            for (int i = 0; i < r_MenuItems.Count; i++)
            {
                MenuItem item = r_MenuItems[i];
                string title = string.Format("{0}. {1}", i, item.Title);
                Console.WriteLine(title);
            }
        }

        private string getMenuTitle()
        {
            return string.Format("{0}. {1}", r_SerialNumber, m_Title);
        }

        public void ShowMenu()
        {
            int chosenAction;
            do
            {
                Console.WriteLine(getMenuTitle());
                Console.WriteLine(sr_Divider);
                this.printItems();
                chosenAction = this.usersChosenAction();
                Console.Clear();
                r_MenuItems[chosenAction].OnSelected();
            } while (chosenAction != sr_ExitOption);
        }

        internal int usersChosenAction()
        {
            int action;
            string exitAction = r_SerialNumber.HasValue ? "Back" : "Exit";
            string message = string.Format("Please enter your choise ({0}-{1} or {2} to {3}",
                                           1, r_MenuItems.Count, sr_ExitOption, exitAction);
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
