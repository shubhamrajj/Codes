using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static binding
            //Circle c=new Circle ();
            //c.Area();
            //c.Perimeter();

            //Square s=new Square ();
            //s.Area();
            //s.Perimeter();

            //dynamic polymorphism


            IShape sh;
            sh = new Circle();
            sh.Area();
            sh.Perimeter();

            sh = new Square();
            sh.Area();
            sh.Perimeter();
        }
    }

    interface IShape
    {
        void Area();
        void Perimeter();
        
    }
    class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Circle");
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle");
        }
       
    }
    class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Square");
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Square");
        }
    }
}
