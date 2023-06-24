using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyLib;

namespace Sample1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Demo d=new Demo();
            Console.WriteLine(d.GetData());

            Test obj=new Test();
            Console.WriteLine(obj.GetMsg());


            ////create instance
            //Employee emp=new Employee();
            //emp.Store(101, "Ramnath", 1111, 201);
            //emp.Display();

            int noOfEmps = 3;
            Employee[] emps = new Employee[3]; //declared array of 3 objects but not yet initialized
            for (int i = 0; i < emps.Length; i++)
            {
                int ec;
                string en;
                int sal;
                int did;
                //Take user-input
                Console.Write("Enter ecode:");
                ec=int.Parse(Console.ReadLine());
                Console.Write("Enter ename:");
                en = Console.ReadLine();
                Console.Write("Enter salary:");
                sal = int.Parse(Console.ReadLine());
                Console.Write("Enter deptid:");
                did = int.Parse(Console.ReadLine());

                //create instance
                emps[i] = new Employee(); //here the array location is initialized with object instance
                //store details into employee instance
                emps[i].Store(ec,en,sal,did);
            }    

            for (int i = 0; i < emps.Length; i++)
            {
                emps[i].Display();
            }
          
        }        
    }

    class Employee
    {
        


        int ecode;
        string ename;
        int salary;
        int deptid;

        public void Store(int ec,string en,int sal, int did)
        {
            ecode = ec;
            ename = en;
            salary = sal;
            deptid = did;
        }
        public void Display()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Employee code:" + ecode);
            Console.WriteLine("Employee name:" + ename);
            Console.WriteLine("Salary       :" + salary);
            Console.WriteLine("Deptid       :" + deptid);
            Console.WriteLine("Bonus        :" + GetBonus());            
        }
        double GetBonus()
        {
            double bonus = 0;
            if(salary>5000)
            {
                bonus = salary * 0.1;
            }
            else
            {
                bonus = salary * 0.2;
            }

            return bonus;
        }
    }
}
