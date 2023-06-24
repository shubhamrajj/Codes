using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorldConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.store();
            emp.display();
        }
    }
    class Employee
    {
        public void store()
        {
            int ecode = 101;
            string emane = "Deep";
        }
        public void display()
        {
            Console.WriteLine("Employee Code:"+ ecode);
            Console.WriteLine("Employee Name:" + ename);
        }
    }
}
