using System;
using System.Threading;
using MenuShell1_2.Domain.Entities;
using MenuShell1_2.Domain.Servises;

namespace MenuShell1_2.Views
{
    public class LoginView
    {
        public void Display()
        {
            const string Adm = "Administrator";
            const string Rec = "Receptionist";
            const string Vet = "Veterinarian";

            User validUser;
            var notLoggedIn = true;

            var authentication = new Authentication();
            var receptionistMainView = new ReceptionistMainView();
//            var veterinarianMainView = new VeterinarianMainView();
            var adminMenu = new AdminMainView();

            do
            {
                Console.Clear();
                Console.WriteLine(" # Login");

                Console.Write("\n Username: ");
                var userName = Console.ReadLine();

                Console.Write(" Password: ");
                var passWord = Console.ReadLine();

                Console.Write("\n Is this correct? (Y)es (N)o");

                var confirm = Console.ReadKey(true).Key;
                Console.WriteLine();

                if (confirm == ConsoleKey.Y)
                {
                    if (authentication.Authenticate(userName, passWord) != null)
                    {
                        validUser = authentication.Authenticate(userName, passWord);
                        notLoggedIn = false;

                        if (validUser.Role == Rec)
                        {
                            Console.Write($"\n\n Successfully logged in as {Rec}");
                            Thread.Sleep(1500);
                            receptionistMainView.Display();
                        }
                        else if (validUser.Role == Vet)
                        {
//                            Console.Write($"\n\n Successfully logged in as {Vet}");
//                            Thread.Sleep(1500);
//                            veterinarianMainView.Display();
                        }
                        else if (validUser.Role == Adm)
                        {
                            Console.Write($"\n\n Successfully logged in as {Adm}");
                            Thread.Sleep(1500);
                            adminMenu.Display();
                        }
                    }
                    else //Invalid user
                    {
                        Console.WriteLine("Invalid username and/or password, try again.");
                        Thread.Sleep(1500);
                    }
                }
                else if (confirm == ConsoleKey.N) //Displays menu again
                {
                    Console.WriteLine("Try again");
                    Thread.Sleep(1000);
                }
            } while (notLoggedIn);
        }
    }
}