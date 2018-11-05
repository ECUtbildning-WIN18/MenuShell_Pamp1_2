using System;
using System.Linq;
using System.Threading;
using MenuShell1_2.Domain.Servises;

namespace MenuShell1_2.Views
{
    public class SearchOwnerView
    {
        public void Display()
        {
            var searchOwner = new SearchOwner();
            var ownerLoader = new OwnerLoader();
            var done = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" # Search Owner");
                Console.WriteLine("\n Search by first or last name:");
                Console.Write("\n > ");

                var searchName = Console.ReadLine();
                var searchHits = searchOwner.OwnerSearch(searchName);
                var deleteUser = new DeleteUser();

                if (searchHits.Any())
                {
                    Console.Clear();
                    Console.WriteLine($" # Users matching your search: {searchName}\n");
                    foreach (var searchHit in searchHits)
                    {
                        Console.WriteLine($" Owner firstname: {searchHit.FirstName}   last name: {searchHit.LastName}");
                    }

                    Console.Write($"\n (D)elete (V)iew (E)xit");

                    var choice = Console.ReadKey(true);

                    if (choice.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        foreach (var searchHit in searchHits)
                        {
                            Console.WriteLine(
                                $" Owner firstname: {searchHit.FirstName}   last name: {searchHit.LastName}");
                        }

                        Console.Write($"\n Delete> ");

                        string userForDeletion = Console.ReadLine();
                        deleteUser.UserDelete(userForDeletion);

                        Thread.Sleep(2000);
                        done = true;
                    }
                    else if (choice.Key == ConsoleKey.V)
                    {
                        Console.Clear();
                        foreach (var searchHit in searchHits)
                        {
                            Console.WriteLine($" Owner: {searchHit.FirstName} {searchHit.LastName}");
                        }

                        Console.Write($"\n View details for user> ");

                        var userForViewing = Console.ReadLine();
                        if (ownerLoader.LoadOwners(userForViewing) != null)
                        {
                            Console.WriteLine(
                                $" First name:             {ownerLoader.LoadOwners(userForViewing).FirstName}.");
                            Console.WriteLine(
                                $" Last name:              {ownerLoader.LoadOwners(userForViewing).LastName}");
                            Console.WriteLine(
                                $" Social Security Number: {ownerLoader.LoadOwners(userForViewing).SocSecNr}");
                            Console.Write("\n Delete user (Y)es (N)o");

                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                Console.Write($"\n Are you certain?  (Y)es (N)o");
                                var confirm = Console.ReadKey(true);
                                if (confirm.Key == ConsoleKey.Y)
                                {
                                    deleteUser.UserDelete(userForViewing);
                                    Console.Write($"User deleted successfully.");
                                    Thread.Sleep(2000);
                                    done = true;
                                }
                            }
                            else
                            {
                                done = true;
                            }
                        }
                        else
                        {
                            Console.Write("Invalid input, press any key");
                            Console.ReadKey();
                            done = true;
                        }
                    }
                    else
                    {
                        done = true;
                    }
                }
                else
                {
                    Console.WriteLine($" No users found matching the search term {searchName}.");
                    Thread.Sleep(2000);
                }
            } while (!done);
        }
    }
}