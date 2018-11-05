using System.Linq;
using MenuShell1_2.Domain.Entities;

namespace MenuShell1_2.Domain.Servises
{
    public class OwnerLoader
    {
        public Owner LoadOwners(string ownerForViewing)
        {
            using (var db = new MenuShellDbContext())
            {
                using (db)
                {
                    var userList = db.Owners.ToList();
                    foreach (var owner in userList)
                    {
                        if (owner.SocSecNr.ToString()==ownerForViewing)
                        {
                            return owner;
                        }
                    }
                }
                return null;
            }
        }
    }
}