using System;
using System.Threading;
using MenuShell1_2.Domain.Entities;
using MenuShell1_2.Domain.Servises;

namespace MenuShell1_2.Views
{
    public class AddOwnerView
    {
        public void Display()
        {
            var addOwner = new AddOwner();
            var done = false;

            do
            {
                Console.Clear();
                Console.WriteLine("# Add new owner");

                Console.Write("\nFirst name: ");
                var firstName = Console.ReadLine();
                Console.Write("Last name: ");
                var lastName = Console.ReadLine();

                Console.Write("\nSocial security number (12 digits): ");
                var socSecNr = long.Parse(Console.ReadLine());

                Console.WriteLine("Is this correct (Y)es (N)o");
                var confirm = Console.ReadKey(true);

                if (confirm.Key == ConsoleKey.Y)
                {
                    addOwner.OwnerAdd(new Owner(firstName, lastName, socSecNr));
                    Console.WriteLine("\nOwner added successfully");
                    Thread.Sleep(1000);
                    done = true;
                }
                else
                {
                    Thread.Sleep(1000);
                    done = true;
                }
            } while (!done);
        }
    }
}