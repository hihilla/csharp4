using System;
namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            TestInterfaces.GenerateMenus().OnSelected();

            TestDelegates.GenerateMenus().OnSelected();
        }
    }
}
