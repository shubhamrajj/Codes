using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst.DAL;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var efDal = new EFDALLayer();
            var lstemps=efDal.GetEmps();

            foreach(var e in lstemps)
            {
                Console.WriteLine($"{e.ecode}\t{e.ename}\t{e.salary}\t{e.deptid}");   
            }
        }
    }
}
