using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemos
{
    internal class EmployeeImplementation
    {
        List<Employee> LstEmps=new List<Employee>();
        public EmployeeImplementation()
        {
            LstEmps.Add(new Employee { Ecode = 101, Ename = "Ravi", Salary = 1111, DeptID = 201 });
            LstEmps.Add(new Employee { Ecode = 102, Ename = "Rohit", Salary = 2222, DeptID = 202 });
            LstEmps.Add(new Employee { Ecode = 103, Ename = "Radhe", Salary = 3333, DeptID = 203 });
            LstEmps.Add(new Employee { Ecode = 104, Ename = "Suresh", Salary = 3333, DeptID = 204 });
            LstEmps.Add(new Employee { Ecode = 105, Ename = "Deep", Salary = 5555, DeptID = 205 });
        }
        public List<Employee> GetEmps()
        {
            return LstEmps;
        }
    }
}
