using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager(101, "Suresh", 50000, 201, 20000);
            mgr.DisplayManager();
        }
    }

    class Employee
    {
        int ecode;
        string ename;
        int salary;
        public Employee(int ecode,string ename,int salary)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
        }
        public void DisplayEmp()
        {
            Console.WriteLine("Ecode    :" + this.ecode);
            Console.WriteLine("Ename    :" + this.ename);
            Console.WriteLine("Salary   :" + this.salary);
        }
    }

    class Manager : Employee
    {
        int deptid;
        int bonus;
        public Manager(int ecode,string ename,int salary,int deptid,int bonus) 
            : base(ecode,ename,salary)
        {
            this.deptid = deptid;
            this.bonus=bonus;
        }
        public void DisplayManager()
        {
            DisplayEmp();
            Console.WriteLine("Deptid   :" + this.deptid);
            Console.WriteLine("Bonus    :" + this.bonus);
        }
    }
}
