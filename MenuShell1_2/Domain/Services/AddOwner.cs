using System.Collections.Generic;
using System.Data.SqlClient;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class AddOwner
    {
        public void OwnerAdd(Owner ownerForAdding)
        {
            using (var context = new MenuShellDbContext())
            {
                context.Owners.Add(ownerForAdding);
                context.SaveChanges();
            }
        }
    }
}