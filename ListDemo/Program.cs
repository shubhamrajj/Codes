using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(30);
            numbers.Add(20);
            numbers.Add(40);
            numbers.Add(50);

            numbers.Sort();

            Display(numbers); 

            List<string> cities = new List<string>();
            cities.Add("Bangalore");
            cities.Add("Mysore");
            cities.Add("Delhi");

            cities.Sort();
            DisplayCities(cities);

            List<Employee> emps = new List<Employee>();

            emps.Add(new Employee { Ecode = 101, Ename = "Ravi", Salary = 1111, Deptid = 201 });
            emps.Add(new Employee { Ecode = 103, Ename = "Rahul", Salary = 3333, Deptid = 202 });
            emps.Add(new Employee { Ecode = 102, Ename = "Raman", Salary = 2222, Deptid = 202 });
            emps.Add(new Employee { Ecode = 104, Ename = "Rohit", Salary = 4444, Deptid = 203 });
            emps.Add(new Employee { Ecode = 105, Ename = "Suresh", Salary = 5555, Deptid = 201 });

            //emps.Sort(); //default sorting based on IComparable<>

            //emps.Sort(new SortBySalary()); //custom sorting based on IComparer<>            
            emps.Sort(new SortByDeptid());
            //emps.Sort(new SortByName());
            

            DisplayEmps(emps);

        }
        public static void  Display(IList<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }

        public static void DisplayCities(IList<string> cities)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine(cities[i]);
            }
        }

        public static void DisplayEmps(IList<Employee> emps)
        {
            for (int i = 0; i < emps.Count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",emps[i].Ecode,emps[i].Ename,emps[i].Salary,emps[i].Deptid);
            }
        }
    }    
}

   