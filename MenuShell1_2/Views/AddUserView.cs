using System;
using System.Threading;
using MenuShell1_2.Domain.Entities;
using MenuShell1_2.Domain.Servises;

namespace MenuShell1_2.Views
{
    public class AddUserView
    {
        public void Display()
        {
            const string Adm = "Administrator";
            const string Rec = "Receptionist";
            const string Vet = "Veterinarian";

            var addUser = new AddUser();
            var done = false;
            
            do
            {
                Console.Clear();
                Console.WriteLine("# Add new user");

                Console.Write("\nUsername: ");
                var userName = Console.ReadLine();
                Console.Write("Password: ");
                var passWord = Console.ReadLine();

                Console.WriteLine("Role: (1) = Receptionist");
                Console.WriteLine("      (2) = Veterinarian");
                Console.WriteLine("      (3) = Administrator");
                Console.Write("> ");

                var roleInt = int.Parse(Console.ReadLine());

                Console.WriteLine("Is this correct (Y)es (N)o");
                var confirm = Console.ReadKey(true);

                if (roleInt == 1)
                {
                    Console.WriteLine(Rec);
                }
                else if (roleInt == 2)
                {
                    Console.WriteLine(Vet);
                }
                else if (roleInt == 3)
                {
                    Console.WriteLine(Adm);
                }

                    if (confirm.Key == ConsoleKey.Y)
                {
                    //Redundant code, I know....

                    if (roleInt == 1 || roleInt == 2 || roleInt == 3)
                    {
                        if (roleInt == 1)
                        {
                            //Console.Write(Rec);
                            addUser.UserAdd(new User(userName, passWord, Rec));
                            Console.WriteLine("\nUser added successfully");
                            Thread.Sleep(1000);
                            done = true;
                        }
                        else if (roleInt == 2)
                        {
                            //Console.Write(Vet);
                            addUser.UserAdd(new User(userName, passWord, Vet));
                            Console.WriteLine("\nUser added successfully");
                            Thread.Sleep(1000);
                            done = true;
                        }
                        else if (roleInt == 3)
                        {
                            //Console.Write(Adm);
                            addUser.UserAdd(new User(userName, passWord, Adm));
                            Console.WriteLine("\nUser added successfully");
                            Thread.Sleep(1000);
                            done = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again");
                        Thread.Sleep(1000);
                    }
                }
            } while (!done);
        }
    }
}