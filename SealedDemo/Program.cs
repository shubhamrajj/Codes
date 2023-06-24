using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C o = new C();
            o.Mbox();
        }
    }

   sealed class University
    {
        public void ExamRules()
        {
            Console.WriteLine("Exam must be conducted before December");
        }
    }

    class College1 
    {
        public void Display()
        {
            University u=new University ();
            u.ExamRules();
        }
    }


    class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent-Display");
        }
    }

    class Child : Parent
    {
        public sealed override void Display()
        {
            Console.WriteLine("Child-Display");
        }
    }
    class Grand : Child
    {
        
    }    
}
