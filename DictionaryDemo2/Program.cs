using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,Customer> customers = new Dictionary<int,Customer>();

            customers.Add(1, new Customer { CustId = 1, Name = "Raghu", City = "Delhi" });
            customers.Add(2, new Customer { CustId = 2, Name = "Ravi", City = "Mysore" });
            customers.Add(3, new Customer { CustId = 3, Name = "Rahul", City = "Jaipur" });
            customers.Add(4, new Customer { CustId = 4, Name = "Rohit", City = "Chennai" });
            customers.Add(5, new Customer { CustId = 5, Name = "Mahesh", City = "Hyderabad" });

            foreach (var k in customers.Keys)
            {
                Customer customer = customers[k];
                Console.WriteLine("{0}\t{1}\t{2}",customer.CustId,customer.Name,customer.City);
            }
        }
    }
}
