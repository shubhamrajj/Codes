using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] seats = new int[10, 15];
            int row = 0;
            int col = 0;
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    seats[i, j] = 0;
                }
            }
            //for (int i = 0; i < seats.GetLength(0); i++)
            // {
            //    for (int j = 0; j < seats.GetLength(1); j++)
            //    {
            //        Console.Write(seats[i, j]+" ") ;
            //     }
            //    Console.WriteLine(" ");
            // }
            while (row < 10 || col < 15)
            {
                // Console.WriteLine("Enter Seat Number :");
                Console.WriteLine("Enter Row Number :");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Column Number :");
                col = int.Parse(Console.ReadLine());
                if (row > 10 || col > 11)
                {
                    Console.WriteLine("No Such Seat Number Exist...");
                    break;
                }
                else if (seats[row, col] == 0)
                {
                    Console.WriteLine("Seat Is Booked");
                    seats[row, col] = 1;
                }
                else
                {
                    Console.WriteLine("Seat Not Available");
                }

            }


        }
    }
}
