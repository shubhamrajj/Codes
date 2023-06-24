using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.DAL
{
    internal class EFDALLayer
    {
        public List<tbl_Employee> GetEmps()
        {
            var lstemps=new List<tbl_Employee>();   

            using(var dbCtx=new CapgDBEntities())
            {
                lstemps=dbCtx.tbl_Employee.ToList();
            }
            return lstemps; 
        }
    }
}
