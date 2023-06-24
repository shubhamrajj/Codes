using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo3
{
    internal class EmployeeImplementation
    {
        List<Employee> emps=new List<Employee>();
        public List<Employee> GetEmps()
        {
            //emps = new List<Employee>();
            //emps.Add(new Employee { Ecode = 101, Ename = "David", Salary = 1111, Deptid = 201 });
            //emps.Add(new Employee { Ecode = 102, Ename = "Alex", Salary = 2222, Deptid = 202 });
            //emps.Add(new Employee { Ecode = 103, Ename = "Tom", Salary = 3333, Deptid = 202 });
            //emps.Add(new Employee { Ecode = 104, Ename = "John", Salary = 4444, Deptid = 203 });
            //emps.Add(new Employee { Ecode = 105, Ename = "Iyan", Salary = 5555, Deptid = 201 });

            return emps;
        }
        public void AddEmployee(Employee emp)
        {
            emps.Add(emp);
        }
        public void DeleteEmpById(int id)
        {
            foreach (var item in emps)
            {
                if (item.Ecode == id)
                {
                    emps.Remove(item);
                    break;
                }
            }
            //for (int i = 0; i < emps.Count; i++)
            //{
            //    if(emps[i].Ecode == id)
            //    {
            //        emps.RemoveAt(i);
            //    }
            //}
        }
        public void UpdateEmp(Employee emp)
        {
            for (int i = 0; i < emps.Count; i++)
            {
                if(emps[i].Ecode==emp.Ecode)
                {
                    emps[i]=emp;
                    break;
                }
            }
        }

        public Employee GetEmpById(int id)
        {
            foreach (var item in emps)
            {
                if(item.Ecode==id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
