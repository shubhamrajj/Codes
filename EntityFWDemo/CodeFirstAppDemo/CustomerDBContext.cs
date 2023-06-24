using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAppDemo
{
    internal class CustomerDBContext:DbContext
    {
        public CustomerDBContext() : base("name=custconstr")
        {
            Database.SetInitializer<CustomerDBContext>(new DropCreateDatabaseIfModelChanges<CustomerDBContext>());
        }
        public DbSet<tbl_customer> tbl_customer { get; set; }
    }
}
