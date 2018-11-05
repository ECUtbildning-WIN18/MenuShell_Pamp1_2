using System;
using System.Threading;

namespace MenuShell1_2.Views
{
    public class ReceptionistMainView
    {
        private bool done = false;

        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" # Receptionist Menu\n");
                Console.WriteLine(" 1. Search owner         A. Search appointment");
                Console.WriteLine(" 2. List owners          B. List appointments");
                Console.WriteLine(" 3. Add owner            C. Register appointment");
                Console.WriteLine(" 4. Search animal");
                Console.WriteLine(" 5. List animals");
                Console.WriteLine(" 6. Add animal");
                Console.WriteLine(" 7. Log out");
                Console.WriteLine(" 8. Exit");
                Console.Write(" > ");

                var choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        var addOwnerView = new AddOwnerView();
                        addOwnerView.Display();
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.B:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.D7:
                        var loginView = new LoginView();
                        loginView.Display();
                        done = true;
                        break;
                    case ConsoleKey.D8:
                        Console.Write("Exiting.");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Write(".");
                        Environment.Exit(0);
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