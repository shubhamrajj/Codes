using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = 0.0;
            double principle = 1000.0;
            int c = 0;
            while(amount< 1000000.0)
            {
                amount = principle * (1+0.05);
                principle = amount;
                c++;
            }
            Console.WriteLine("Time required "+c+" years");

        }
    }
}
