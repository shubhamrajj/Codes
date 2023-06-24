using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var customer = new tbl_customer();
            Console.WriteLine("Enter Customer ID :");
            customer.Id =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name :");
            customer.Name =Console.ReadLine();
            Console.WriteLine("Enter City Name :");
            customer.City = Console.ReadLine();
            Console.WriteLine("Enter Country Name :");
            customer.Country=Console.ReadLine();

            var efDal = new DBFirstDALLayer();
            efDal.AddCustomer(customer);
            Console.WriteLine("Records Inserted !!!");


        }
    }
}
