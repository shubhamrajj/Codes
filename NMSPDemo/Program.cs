using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini;
using Capgemini.Blr;
using Capgemini.Delhi;

namespace NMSPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Capgemini.Blr.Test obj = new Capgemini.Blr.Test();
            obj.Display();

            Capgemini.Delhi.Test obj2 = new Capgemini.Delhi.Test();
            obj2.Display();


            Batch35 b1 = new Batch35(60, "Ramnath");
            b1.Display();


            Batch37 b2 = new Batch37();
            b2.Display();

            Coordinator coord = new Coordinator();

        }       
    }   
}
 