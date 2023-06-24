using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);


            Console.WriteLine("Traversing using for-index loop");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\nTraversing using foreach loop");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTraversing using IEnumerator interface");
            var ien=list.GetEnumerator();            
            while(ien.MoveNext())
            {
                int v=ien.Current;
                Console.WriteLine(v);
            }    
        }
    }


    
}
