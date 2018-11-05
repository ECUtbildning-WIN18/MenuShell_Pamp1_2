using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class UserLoader
    {
        public User LoadUsers(string userName)
        {

            using (var db = new MenuShellDbContext())
            {
                using (db)
                {
                    var userList = db.Users.ToList();
                    foreach (var user in userList)
                    {
                        if (user.Username.StartsWith(userName))
                        {
                            return user;
                        }
                    }
                }
                return null;
            }


            //var users = new Dictionary<string, User>();

            //string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //string queryString = $"SELECT [Username], [Password], [Role] FROM [User] WHERE Username = '{userName}'";

            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    var sqlCommand = new SqlCommand(queryString, connection);

            //    var reader = sqlCommand.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var user = new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
            //        return user;
            //    }
            //    connection.Close();
            //}
        }
    }
}