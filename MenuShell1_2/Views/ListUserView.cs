using System;
using MenuShell1_2.Domain.Servises;

namespace MenuShell1_2.Views
{
    public class ListUserView
    {
        public void Display()
        {
            var listUser = new ListUser();
            var userList = listUser.UserList();

            Console.Clear();
            Console.WriteLine(" # List of users:\n");
            foreach (var user in userList)
            {
                Console.WriteLine($" Username: {user.Username}   Password: {user.Password}   Role: {user.Role}");
            }
            Console.Write("\n Press any key to go back");
            Console.ReadKey(true);
        }
    }
}