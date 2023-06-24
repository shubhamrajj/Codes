using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


            namespace MyProject
    {
        abstract class baseclass
        {
            public int i;
            public int j;
            public abstract void print();
        }
        class derived : baseclass
        {
            public int j = 5;
            public override void print()
            {
                this.j = 3;
                Console.WriteLine(i + " " + j);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                derived obj = new derived();
                obj.i = 1;
                obj.print();
                Console.ReadLine();
            }
        }
    }
    

