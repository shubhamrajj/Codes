using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int principle, time;
            double rate;
            Console.Write("Enter the Principle Amount: ");
            principle = int.Parse(Console.ReadLine());
            Console.Write("Enter the Time: ");
            time= int.Parse(Console.ReadLine());
            Console.Write("Enter the rate: ");
            rate = double.Parse(Console.ReadLine());
            double SI;
            SI = ((principle * time * rate) / 100.0);
            Console.WriteLine("Simple Interest :"+SI);
        }
    }
}
