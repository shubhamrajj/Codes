using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interest;

namespace DemoLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter :\n1.Simple Interest\n2.Compound Imterest");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:

                    Console.WriteLine("Principle :");
                    int p = int.Parse(Console.ReadLine());
                    Console.WriteLine("Rate :");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Time :");
                    int t = int.Parse(Console.ReadLine());
                    SimpleInterest si = new SimpleInterest();
                    Console.WriteLine("Simple Interest :"+si.CalculateInterest(p, r, t));
                    break;
                case 2:
                    Console.WriteLine("Principle :");
                    double P = double.Parse(Console.ReadLine());
                    Console.WriteLine("Rate :");
                    double R = double.Parse(Console.ReadLine());
                    Console.WriteLine("Time :");
                    double T = double.Parse(Console.ReadLine());
                    CompoundInterest ci = new CompoundInterest();
                    Console.WriteLine("Compound Interest :"+ci.CalculateInterest(P,R,T));
                    break;

            }
        
        }
    }
}
