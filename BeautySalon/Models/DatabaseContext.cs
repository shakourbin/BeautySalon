using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
            System.Data.Entity.Database.SetInitializer
            (new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }

        public DatabaseContext():base()
        {
        }

        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<Employee> Employees { get; set; }
    }
}