using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public void Display()
        {
            Console.WriteLine("{0}\t{1}\t{2}",CustId,Name,City);
        }
    }
}
