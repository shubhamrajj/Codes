using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyLib;

namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Test t=new Test ();
            Console.WriteLine(t.GetMsg());

            Demo demo = new Demo ();
            Console.WriteLine(demo.GetData());

            Employee e1 = new Employee(101,"Ravi",1111);
            //e1.Id = 101;
            //e1.Name = "Ravi";
            //e1.Salary = 1111;
            //Employee.Company = "CapGemini";
           

            Console.WriteLine("Ecode:" + e1.Id);
            Console.WriteLine("Name:" + e1.Name);
            Console.WriteLine("Salary:" + e1.Salary);
            Console.WriteLine("Company:" + Employee.Company);


            Employee e2 = new Employee(102, "Raman", 2222);
            Console.WriteLine("Ecode:" + e2.Id);
            Console.WriteLine("Name:" + e2.Name);
            Console.WriteLine("Salary:" + e2.Salary);
            Console.WriteLine("Company:" + Employee.Company);
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static string Company { get; set; }

        public Employee(int id,string name,int sal)
        {
            Id = id;
            Name = name;
            Salary = sal;
            Company = "CapGemini"; //non static methods can refer static as well as non-static members
            Console.WriteLine("non-static ctor called");
        }
        static Employee()
        {
            //Id = id; //static methods can only refer other static methods or fields
            //Name = name;
            //Salary = sal;
            Employee.Company = "ABC";
            Console.WriteLine("static ctor called");
        }    
    }
}
