using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of customer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Rating is out of 5");
            Console.WriteLine("\n");
            double[] customer = new double[n];
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the rating of customer {0} :", (i + 1));
                customer[i] = double.Parse(Console.ReadLine());
                sum += customer[i];
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rating of Customer {0} : {1} out of 5", (i + 1), customer[i]);
            }
            double average = 0.0;
            average = sum / n;
            Console.WriteLine("\nAverage Rating :{0:.00}", average);


        }
    }
}