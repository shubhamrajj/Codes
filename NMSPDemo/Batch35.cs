using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini
{
    namespace Delhi
    {
        class Test
        {
            public void Display()
            {
                Console.WriteLine("CG.Delhi.Test.Display");
            }
        }
        class Batch35
        {
            public int Duration { get; set; }
            public string Faculty { get; set; }
            public Batch35(int duration, string faculty)
            {
                this.Duration = duration;
                this.Faculty = faculty;
            }
            public void Display()
            {
                Console.WriteLine("Batch 35");
                Console.WriteLine("Duration:" + Duration);
                Console.WriteLine("Faculty :" + Faculty);
            }
        }

        class Batch36
        {
            public void Display()
            {
                Console.WriteLine("Batch 36");
                Console.WriteLine("Start Date: 20th Jan 2022");
                Console.WriteLine("End Date  : 11th Apr 2022");
            }
        }
    }  
}
