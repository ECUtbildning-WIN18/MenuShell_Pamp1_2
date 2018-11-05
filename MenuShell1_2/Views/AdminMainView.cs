using System;
using System.Threading;

namespace MenuShell1_2.Views
{
    public class AdminMainView
    {
        private bool done = false;
        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" # Admin menu\n");
                Console.WriteLine(" 1. Manage users");
                Console.WriteLine(" 2. Log out");
                Console.WriteLine(" 3. Exit");
                Console.Write(" > ");

                var choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.D1)
                {
                    var manageUserView = new ManageUserView();
                    manageUserView.Display();
                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    var loginView = new LoginView();
                    loginView.Display();
                    done = true;
                }
                else if (choice.Key == ConsoleKey.D3)
                {
                    Console.Write("Exiting.");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    Thread.Sleep(750);
                }
            } while (!done);
        }
    }
}