using System.Collections.Generic;
using System.Data.SqlClient;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class AddUser
    {
        public void UserAdd(User userForAdding)
        {
            using (var context = new MenuShellDbContext())
            {
                context.Users.Add(userForAdding);
                context.SaveChanges();
            }

            //var users = new List<User>();

            //string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //string queryString = $"INSERT INTO [User] VALUES('{userForAdding.Username}', '{userForAdding.Password}', " +
            //                     $"'{userForAdding.Role}')";

            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    var sqlCommand = new SqlCommand(queryString, connection);

            //    sqlCommand = new SqlCommand(queryString, connection);

            //    sqlCommand.ExecuteReader();

            //    connection.Close();
            //}
        }
    }
}