using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    enum dept
    {
        Account,
        Admin,
        Sales

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double bonus = 0.0;
            Console.WriteLine("Enter Employee ID :");
            int inputid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary :");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Name   :" + name);
            Console.WriteLine("Salary :" + salary);
            if (inputid == 201)
            {
                Console.WriteLine("Department :{0}", dept.Account);
                bonus = salary * 0.1;
                Console.WriteLine("Bonus  :" + bonus);
            }
            else if (inputid == 201)
            {
                Console.WriteLine("Department :{0}", dept.Admin);
                bonus = salary * 0.2;
                Console.WriteLine("Bonus: " + bonus);
            }
            else if (inputid == 203)
            {
                Console.WriteLine("Department :{0}", dept.Sales);
                bonus = salary * 0.3;
                Console.WriteLine("Bonus: " + bonus);
            }
            else
                Console.WriteLine("Invalid Input");
        }
    }
}