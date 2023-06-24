using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mt = 0.0;
            double r = 0.015;
            double balance = 1000.0;
            int m=0;int tp = 0;
            Console.WriteLine("Enter the monthly payments :");
            mt = double.Parse(Console.ReadLine());
            while (balance > 0.0)
            {
                 balance = balance + (balance * r) - mt;
                m++;
                tp += 100;
                Console.WriteLine("Month:  " + m + "  balance  " + balance + " total payments: " + tp);
              }
            
        }
    }
}
