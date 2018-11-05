using System.Data.SqlClient;
using System.Linq;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class DeleteUser
    {
        public void UserDelete(string userNameForDeletion)
        {
            using (var db = new MenuShellDbContext())
            {
                var foundUser = db.Users.FirstOrDefault(x => x.Username == userNameForDeletion);

                if (foundUser == null) return;

                db.Users.Remove(foundUser);
                db.SaveChanges();
            }

            //var sqlCommand = new SqlCommand();

            //string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string queryString = $"DELETE FROM [User] WHERE Username = '{userNameForDeletion}'";

            //    sqlCommand = new SqlCommand(queryString, connection);

            //    sqlCommand.ExecuteReader();

            //    connection.Close();
            //}
        }
    }
}