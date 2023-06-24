using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndCtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child(100,200);
            c.DisplayParent();
            c.DisplayChild();
        }
    }

    class Parent
    {
        int p;
        public Parent(int a)
        {
            p = a;
            Console.WriteLine("Parent-Default ctor called");
        }
        public void DisplayParent()
        {
            Console.WriteLine("Parent P:" + p);
        }
    }

    class Child : Parent
    {
        int c;
        public Child(int x,int a) : base(a)  //constructor chaining
        {
            c = x;
            Console.WriteLine("Child constructor called");
        }
        public void DisplayChild()
        {
            Console.WriteLine("Child C:" + c);
        }
    }
}
