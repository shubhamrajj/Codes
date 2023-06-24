using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAppDemo
{
    internal class DBFirstDALLayer
    {
        public void AddCustomer(tbl_customer customer)
        {
            using(var dbCtx=new CustomerDBContext())
            {
                dbCtx.tbl_customer.Add(customer);
                dbCtx.SaveChanges();
            }
        }
    }
}
