using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeImplementation empImpl=new EmployeeImplementation();
            var lstEmps=empImpl.GetEmps();

            //1--Using Query Operators
            var res1 = (from emp in lstEmps 
                        where emp.Salary > 3000
                        orderby emp.Salary descending,emp.Ecode ascending
                        select emp).ToList();

            //--Using Extension methods

            res1 = lstEmps.Where(emp => emp.Salary > 3000).OrderByDescending(emp => emp.Salary).ThenBy(emp => emp.Ecode).ToList();

            DisplayEmps(res1);

            Console.WriteLine("====================================================");

            //2-- using Query operator

            var res2=from emp in lstEmps
                     where (emp.DeptID ==201)
                     select new {emp.Ecode, emp.Salary,emp.DeptID};
           
            //--Using Extension methods and Lamda Expression

            res2=lstEmps.Where(emp=>emp.DeptID==201).Select(emp=>new {emp.Ecode,emp.Salary,emp.DeptID}).ToList();

            foreach (var item in res2)
            {
                Console.WriteLine($"{item.Ecode}\t{item.Salary}\t{item.DeptID}");
            }

            //--3
            var grpres1 = new
            {
                TotalSal = lstEmps.Sum(emp => emp.Salary),
                AvgSal =lstEmps.Average(emp => emp.Salary),
                MaxSal=lstEmps.Max(emp => emp.Salary),
                MinSal=lstEmps.Min(emp=>emp.Salary),
                NoOfEmp=lstEmps.Count()
            };
            Console.WriteLine("\n");
            Console.WriteLine("Total Salary    :" +grpres1.TotalSal);
            Console.WriteLine("Average Salary  :" + grpres1.AvgSal);
            Console.WriteLine("Maximum Salary  :" + grpres1.MaxSal);
            Console.WriteLine("Minimum Salary  :" + grpres1.MinSal);
            Console.WriteLine("No of Employees :" + grpres1.NoOfEmp);


        //--



        }
        static void LINQBasic()
        {
            int[] num = { 2, 4, 45, 12, 34, 36, 0, 78, 23, 65, 93 };

            //find the even numbers

            var result = from n in num where n % 2 == 0 && n > 5 orderby n descending select n;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayEmps(List<Employee> res)
        {
            //Display

            foreach (var item in res)
            {
                Console.WriteLine($"{item.Ecode}\t{item.Ename}\t{item.Salary}\t{item.DeptID}");
            }
        }
    }
}
