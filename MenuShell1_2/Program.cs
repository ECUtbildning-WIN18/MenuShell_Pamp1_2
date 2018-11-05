using System.Linq;
using MenuShell1_2.Domain.Entities;
using MenuShell1_2.Views;

namespace MenuShell1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            using (var context = new MenuShellDbContext())
            {
                var users = context.Users.ToList();
            }
            var loginView = new LoginView();
            loginView.Display();
        }
    }
}