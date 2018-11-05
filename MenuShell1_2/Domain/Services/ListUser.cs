using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class ListUser
    {
        public List<User> UserList()
        {
            using (var db = new MenuShellDbContext())
            {
                var userList = db.Users.ToList();
              
                return userList;
            }

            //var sqlCommand = new SqlCommand();
            //var userList = new List<User>();
            
            //string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //string queryString = $"SELECT [Username], [Password], [Role] FROM [User]";

            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    sqlCommand = new SqlCommand(queryString, connection);
                
            //    var reader = sqlCommand.ExecuteReader();

            //    userList = new List<User>();

            //    while (reader.Read())
            //    {
            //        userList.Add(new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            //    }
            //    connection.Close();
            //}
            //return userList;
        }
    }
}