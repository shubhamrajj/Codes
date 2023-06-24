using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int average = 0;
            int total = 0;
            Console.Write("Enter marks of 5 students: ");
            for (int i = 0; i < 5; i++)
            {

                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }
            average = total / 5;
            Console.Write("Marks      :");
            for (int j = 0; j < 5; j++)
            {

                Console.Write(marks[j]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Total Marks:   " + total);
            Console.WriteLine("Average Marks: " + average);
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                    Console.WriteLine("Result: Failed");

                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else if (marks[i] > 35 && average > 50)
                    Console.WriteLine("Result : Pass");
                break;
            }

        }
    }
}