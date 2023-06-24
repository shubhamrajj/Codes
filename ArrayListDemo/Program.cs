using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections; 


namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrLst = new ArrayList();
            arrLst.Add(10);
            arrLst.Add(20);
            arrLst.Add("AAA");
            arrLst.Add(40);
            arrLst.Add(50.5);
            arrLst.Add(11.3f);
            arrLst.Add(new Employee("Ravi"));

            foreach (object item in arrLst)
            {
                if(item is int)
                {
                    int v=(int)item;
                    Console.WriteLine(v);
                }
                else if(item is string)
                {
                    string s = (string)item;
                    Console.WriteLine(s);
                }
                else if(item is double)
                {
                    double d=(double)item;
                    Console.WriteLine(d);
                }
                else if(item is float)
                {
                    float f=(float)item;
                    Console.WriteLine(f);
                }
                else if(item is Employee)
                {
                    Employee emp= (Employee)item;
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            this.Name = name;
        }
    }
}
