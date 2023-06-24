using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "Welcome to Bangalore" ;
            string[] word = line.Split(' ');
            for (int i = 0; i <word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
            char[] letters=line.ToCharArray();
            for (int i = 0;i<letters.Length;i++)
            {
                Console.WriteLine(letters[i]);
            }
            string joinedLine=string.Join(" ", letters);
            Console.WriteLine(joinedLine);
            string s1 = "Deepsubho".Substring(0,4);
            Console.WriteLine(s1);
           

        }
    }
}
