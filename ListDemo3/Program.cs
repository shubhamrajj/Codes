using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeImplementation empImpl=new EmployeeImplementation();
            int choice;
            
            do
            {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Display all emps");
                Console.WriteLine("3.Delete emp by Id");
                Console.WriteLine("4.Update emp by Id");
                Console.WriteLine("5.Find emp by Id");
                Console.WriteLine("6.Exit");
                Console.Write("Enter choice:");
                choice=int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Employee emp = new Employee();
                        Console.Write("Enter ecode:");
                        emp.Ecode = int.Parse(Console.ReadLine());
                        Console.Write("Enter ename:");
                        emp.Ename = Console.ReadLine();
                        Console.Write("Enter salary:");
                        emp.Salary = int.Parse(Console.ReadLine());
                        Console.Write("Enter deptid:");
                        emp.Deptid = int.Parse(Console.ReadLine());

                        empImpl.AddEmployee(emp);
                        Console.WriteLine("Record inserted");                       
                        break;
                    case 2:
                        var lstEmps = empImpl.GetEmps();
                        if(lstEmps.Count==0)
                        {
                            Console.WriteLine("No records to display");
                        }
                        else
                        {
                            DislayEmps(lstEmps);
                        }                       
                        break;
                    case 3:
                        //for delete by id
                        Console.Write("Enter ecode for deletion:");
                        int ec=int.Parse(Console.ReadLine());
                        empImpl.DeleteEmpById(ec);
                        Console.WriteLine("Record deleted");
                        break;

                    case 4:
                        //for update record
                        Employee record = new Employee();
                        Console.Write("Enter ecode for update:");
                        record.Ecode=int.Parse(Console.ReadLine());
                        Console.Write("Enter ename:");
                        record.Ename = Console.ReadLine();
                        Console.Write("Enter salary:");
                        record.Salary = int.Parse(Console.ReadLine());
                        Console.Write("Enter deptid:");
                        record.Deptid = int.Parse(Console.ReadLine());

                        empImpl.UpdateEmp(record);
                        Console.WriteLine("Record updated");
                        break;
                    case 5:
                        //for search by id
                        Console.Write("Enter ecode for search:");
                        int id=int.Parse(Console.ReadLine());

                        Employee e=empImpl.GetEmpById(id);
                        if(e==null)
                        {
                            Console.WriteLine("Record not found");
                        }
                        else
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}",e.Ecode,e.Ename,e.Salary,e.Deptid);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exited....");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }while(choice!=6);    
        }
        static void DislayEmps(List<Employee> lstEmps)
        {
            foreach (var e in lstEmps)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Ecode, e.Ename, e.Salary, e.Deptid);
            }
        }
    }
}
