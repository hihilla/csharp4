using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu
    {
        internal string m_Title = "";
        internal readonly List<IMenuItem> r_MenuItems;
        internal readonly Nullable<int> r_SerialNumber;
        internal static readonly string sr_Divider = "================";
        internal static readonly int sr_ExitOption = 0;

        internal Menu()
        {
            this.r_MenuItems = new List<IMenuItem>();
        }

        internal Menu(string i_Title, Nullable<int> i_Level)
        {
            this.m_Title = i_Title;
            this.r_SerialNumber = i_Level;
            this.r_MenuItems = new List<IMenuItem>();
        }

        internal Menu(string i_Title, Nullable<int> i_Level, List<IMenuItem> i_Items)
        {
            this.m_Title = i_Title;
            this.r_SerialNumber = i_Level;
            this.r_MenuItems = new List<IMenuItem>(i_Items);
        }

        public void AddMenuItem(IMenuItem i_Item, int i_Level)
        {
            r_MenuItems.Insert(i_Level, i_Item);
        }

        internal void printItems()
        {
            for (int i = 0; i < r_MenuItems.Count; i++)
            {
                IMenuItem item = r_MenuItems[i];
                string title = string.Format("{0}. {1}", i, item.GetTitle());
                Console.WriteLine(title);
            }
        }

        virtual internal string getMenuTitle()
        {
            return string.Format("{0}. {1}", r_SerialNumber, m_Title);
        }

        public void OnSelected()
        {
            ShowMenu();
        }

        internal void ShowMenu()
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
            string message = string.Format("Please enter your choise ({0}-{1} or {2} to {3})",
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
