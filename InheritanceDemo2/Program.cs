using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Permanent");
            Console.WriteLine("2.Contractual");
            Console.WriteLine("3.Exit");
            Console.Write("Enter choice:");
            int choice=int.Parse(Console.ReadLine());

            if(choice==1)
            {
                Permanent emp1 = new Permanent();
                Console.Write("Enter ecode:");
                emp1.Ecode=int.Parse(Console.ReadLine());
                Console.Write("Enter ename:");
                emp1.Ename = Console.ReadLine();
                Console.Write("Enter deptid:");
                emp1.Deptid = int.Parse(Console.ReadLine());
                Console.Write("Enter salary:");
                emp1.Salary = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus:");
                emp1.Bonus = int.Parse(Console.ReadLine());

                emp1.CalculateAnnualSalary();
                Console.WriteLine("Permanent Employee's Details");
                Console.WriteLine("Ecode        :" + emp1.Ecode);
                Console.WriteLine("Ename        :" + emp1.Ename);
                Console.WriteLine("Deptid       :" + emp1.Deptid);
                Console.WriteLine("Annual Salary:" + emp1.Salary);
            }
            else if(choice==2)
            {
                Contractual emp2 = new Contractual();
                Console.Write("Enter ecode:");
                emp2.Ecode = int.Parse(Console.ReadLine());
                Console.Write("Enter ename:");
                emp2.Ename = Console.ReadLine();
                Console.Write("Enter deptid:");
                emp2.Deptid = int.Parse(Console.ReadLine());
                Console.Write("Enter total hours worked:");
                emp2.TotalHoursWorked = int.Parse(Console.ReadLine());

                emp2.CalculateAnnualSalary();
                Console.WriteLine("Contractual Employee's Details");
                Console.WriteLine("Ecode        :" + emp2.Ecode);
                Console.WriteLine("Ename        :" + emp2.Ename);
                Console.WriteLine("Deptid       :" + emp2.Deptid);
                Console.WriteLine("Total Salary :" + emp2.Salary);
            }
            else
            {
                Console.WriteLine("Exited...");
            }
        }
    }

    class Employee
    {
        public int Ecode { get; set; } 
        public string Ename { get; set; }

        public int Deptid { get; set; }
        public double Salary { get; set; }

       
    }
    class Permanent : Employee
    {
        public  double Bonus { get; set; }
        public void  CalculateAnnualSalary()
        {
            double annualSalary = 12 * Salary + Bonus;
            Salary= annualSalary;
        }
    }

    class Contractual : Employee
    {
        public int TotalHoursWorked { get; set; }
        public void  CalculateAnnualSalary()
        {
            double annualSalary = TotalHoursWorked * 1000;
            Salary= annualSalary;
        }
    }
}
