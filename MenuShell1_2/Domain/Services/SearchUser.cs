using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class SearchUser
    {
        public List<User> UserSearch(string searchString)
        {
            using (var db = new MenuShellDbContext())
            {
                var userList = db.Users.ToList();
                var searchHits = new List<User>();

                foreach (var user in userList)
                {
                    if (user.Username.StartsWith(searchString))
                    {
                        searchHits.Add(user);
                    }
                }
                return searchHits;

            }

            //var sqlCommand = new SqlCommand();



            //string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string queryString = $"SELECT [Username], [Password], [Role] FROM [User] WHERE Username LIKE '{searchString}%'";

            //    sqlCommand = new SqlCommand(queryString, connection);

            //    var reader = sqlCommand.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        searchHits.Add(new User(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            //    }
            //    connection.Close();
            //}
        }
    }
}