using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Employee : IComparable<Employee>
    {
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }

        public int CompareTo(Employee other)
        {
            if(this.Ecode>other.Ecode)
            {
                return 1;
            }
            else if(this.Ecode<other.Ecode)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }


    class SortBySalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if(x.Salary>y.Salary)
            {
                return 1;
            }
            else if(x.Salary<y.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class SortByDeptid : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Deptid > y.Deptid)
            {
                return 1;
            }
            else if (x.Deptid < y.Deptid)
            {
                return -1;
            }
            else
            {
                //ThenBySort
                if(x.Salary>y.Salary)
                {
                    return -1;
                }
                else if(x.Salary < y.Salary)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }                
            }
        }
    }
    class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
           return x.Ename.CompareTo(y.Ename);
        }
    }
}
