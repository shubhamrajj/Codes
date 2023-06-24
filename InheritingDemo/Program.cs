using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter :\t1.Permanent Employee\n\t2.Contractual Employess\n\t3.Exit");
            int n=int.Parse(Console.ReadLine());
            if (n == 1)
            {
                
                Permanent emp1=new Permanent();
                Console.WriteLine("Enter Ecode :");
                emp1.Ecode=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Ename :");
                emp1.Ename=Console.ReadLine();
                Console.WriteLine("Enter DeptID :");
                emp1.DeptID=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary");

                Console.WriteLine("Enter Bonus :");
                emp1.Bonus=int.Parse(Console.ReadLine());

                Console.WriteLine("Permanent Employee Details :");
                emp1.Annual_Salary();
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n",emp1.Ecode,emp1.Ename,emp1.DeptID,emp1.Salary);
            }
            else if (n == 2)
            {
                Console.WriteLine("Contractual Employee Details :");
                Contractual emp2 = new Contractual();
                Console.WriteLine("Enter Ecode :");
                emp2.Ecode = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Ename :");
                emp2.Ename = Console.ReadLine();
                Console.WriteLine("Enter DeptID :");
                emp2.DeptID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                emp2.Salary=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Total Hours Worked :");
                emp2.TotalhoursWorked = int.Parse(Console.ReadLine());

                Console.WriteLine("Contractual Employee Details :");
                emp2.Total_Salary();
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", emp2.Ecode, emp2.Ename, emp2.DeptID, emp2.Salary);
            }
            else
            {
                Console.WriteLine("Exited...");
            }
        }
        class Employee
        {
            public int Ecode { get; set; }
            public string Ename { get; set; }    
            public int DeptID { get; set; }
            public int Salary { get; set; }
        }
        class Permanent : Employee
        {
            public int Bonus { get; set; }
            public void Annual_Salary()
            {
                int AnnualSalary = 12 * Salary + Bonus;
                Salary = AnnualSalary;
            }
        }
        class Contractual : Employee
        {
            public int TotalhoursWorked { get; set; }
            public void Total_Salary()
            {
                int TotalSalary = TotalhoursWorked * 1000;
                Salary = TotalSalary;
            }
        }
    }
}
