using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Now;
            Console.WriteLine("dt :"+dt);
            DateTime dt1 = new DateTime(2001, 08, 18, 12, 35, 45);
            Console.WriteLine("dt1 :"+dt1);

        }
    }
}
