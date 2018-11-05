using System;
using System.Threading;

namespace MenuShell1_2.Views
{
    public class ManageUserView
    {
        public void Display()
        {
            var done = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" # User management menu");
                Console.WriteLine("\n 1. Search user");
                Console.WriteLine(" 2. Add user");
                Console.WriteLine(" 3. List users");
                Console.WriteLine(" 4. Return to main menu");
                Console.Write(" > ");

                var choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        var searchUserView = new SearchUserView();
                        searchUserView.Display();
                        break;
                    case ConsoleKey.D2:
                        var addUserView = new AddUserView();
                        addUserView.Display();
                        break;
                    case ConsoleKey.D3:
                        var listUserView = new ListUserView();
                        listUserView.Display();
                        break;
                    case ConsoleKey.D4:
                        Console.Write("Exiting.");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");

                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        Thread.Sleep(750);
                        break;
                } 
            } while (!done);
        }
    }
}