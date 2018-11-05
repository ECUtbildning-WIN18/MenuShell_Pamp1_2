using System.Collections.Generic;
using System.Data.SqlClient;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class AddOwner
    {
        public void OwnerAdd(Owner ownerForAdding)
        {
            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            string queryString = $"INSERT INTO [Owner] VALUES('{ownerForAdding.FirstName}', '{ownerForAdding.LastName}', " +
                                 $"'{ownerForAdding.SocSecNr}')";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sqlCommand = new SqlCommand(queryString, connection);
                
                sqlCommand = new SqlCommand(queryString, connection);

                sqlCommand.ExecuteReader();
                
                connection.Close();
            }
        }
    }
}