using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell1_2.Domain.Entities
{
    class MenuShellDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public MenuShellDbContext() : base("MenuShellDbContext")
        {

        }
    }
}
