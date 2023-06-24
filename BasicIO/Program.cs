using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result, choice;
            Console.Write("Input First number:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Input Second number:");
            n2 = int.Parse(Console.ReadLine());
            result = n1 + n2;
            Console.Write("Choose 1:ADD 2:SUBTRACT 3:MULTIPLY  ");
            choice = int.Parse(Console.ReadLine());
            if(choice==1)
            {
                Console.WriteLine("SUM:"+(n1+n2));
            }
            else if(choice==2)
            {
                Console.WriteLine("SUBTRACTION:"+(n1-n2));
            }
            else if(choice==3)
            {
                Console.WriteLine("MULTIPLY:"+(n1*n2));
            }
            else
                Console.WriteLine("INVALID CHOICE");
        }
    }
}
