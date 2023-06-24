using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks = 35;

            University u;

            Console.WriteLine("Result at University");
            u = new University();
            u.CalculateResult(marks);

            Console.WriteLine("Result at College1");
            u=new College1();
            u.CalculateResult(marks);            

            Console.WriteLine("Result at College2");
            u=new College2();
            u.CalculateResult(marks);

        }
    }

    class University
    {
        public virtual void CalculateResult(int marks)
        {
            if(marks>=50)
            {
                Console.WriteLine("Result:PASS");
            }
            else
            {
                Console.WriteLine("Result:FAILED");
            }
        }
        //public void Admission()
        //{
        //    Console.WriteLine("University-Admission");
        //}
    }

    class College1 : University
    {
        public override void CalculateResult(int marks)
        {
            if (marks >= 60)
            {
                Console.WriteLine("Result:PASS");
            }
            else
            {
                Console.WriteLine("Result:FAILED");
            }
        }
        //public void RegisterForExam()
        //{
        //    Console.WriteLine("Register - College1");
        //}
    }
    class College2 : University
    {
        public override void CalculateResult(int marks)
        {
            if (marks >= 45)
            {
                Console.WriteLine("Result:PASS");
            }
            else
            {
                Console.WriteLine("Result:FAILED");
            }
        }
    }
}




interface A
{

}
interface B
{

}
class C:A,B
{

}