using System;
using System.Linq;
using System.Threading;
using MenuShell1_2.Domain.Servises;

namespace MenuShell1_2.Views
{
    public class SearchUserView
    {
        public void Display()
        {
            var searchUser = new SearchUser();
            var userLoader = new UserLoader();
            var done = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" # Search User");
                Console.WriteLine("\n Search by username:");
                Console.Write("\n > ");

                var searchName = Console.ReadLine();
                var searchHits = searchUser.UserSearch(searchName);
                var deleteUser = new DeleteUser();

                if (searchHits.Any())
                {
                    Console.Clear();
                    Console.WriteLine($" # Users matching your search: {searchName}\n");
                    foreach (var searchHit in searchHits)
                    {
                        Console.WriteLine($" Username: {searchHit.Username}");
                    }

                    Console.Write($"\n (D)elete (V)iew (E)xit");

                    var choice = Console.ReadKey(true);

                    if (choice.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        foreach (var searchHit in searchHits)
                        {
                            Console.WriteLine($" Username: {searchHit.Username}");
                        }

                        Console.Write($"\n Delete> ");

                        string userForDeletion = Console.ReadLine();
                        deleteUser.UserDelete(userForDeletion);

                        Console.WriteLine($" User with username: {userForDeletion}  deleted successfully.");
                        Thread.Sleep(2000);
                        done = true;
                    }
                    else if (choice.Key == ConsoleKey.V)
                    {
                        Console.Clear();
                        foreach (var searchHit in searchHits)
                        {
                            Console.WriteLine($" Username: {searchHit.Username}");
                        }

                        Console.Write($"\n View details for user> ");

                        var userForViewing = Console.ReadLine();
                        if (userLoader.LoadUsers(userForViewing) != null)
                        {
                            Console.WriteLine($" User name:     {userLoader.LoadUsers(userForViewing).Username}.");
                            Console.WriteLine($" User password: {userLoader.LoadUsers(userForViewing).Password}");
                            Console.WriteLine($" User role:     {userLoader.LoadUsers(userForViewing).Role}");
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