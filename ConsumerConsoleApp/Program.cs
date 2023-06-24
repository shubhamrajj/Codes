using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoLib;

namespace ConsumerConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustId = 1;
            customer.Name = "Alex";
            customer.City = "Texas";

            customer.Display();


            Product product = new Product();
            product.Id = 1001;
            product.Name = "iPhone";
            product.Price = 40000;

            Console.WriteLine("{0}\t{1}\t{2}",product.Id,product.Name,product.Price);
        }
    }
}
