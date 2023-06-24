using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4;
        l1: while (a < 4)
            {
                a++;
                while (b < 5)
                {
                    Console.WriteLine("Hi\n");
                    goto l1;
                }
            }
            Console.ReadLine();
        }
        
    }
}

