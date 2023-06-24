using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PersonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            people[0] = new Person { Name = "Alex", Address = "Texas", Age = 69 };
            people[1] = new Person { Name = "David", Address = "Cananda", Age = 43 };
            people[2] = new Person { Name = "John", Address = "Italy", Age = 60 };

            PersonImplementation pil = new PersonImplementation();
            pil.DisplayPerson(people);

            double avgAge = pil.Average(people);
            Console.WriteLine("Avg age:" + avgAge);

            int maxAge = pil.MaxAge(people);
            Console.WriteLine("Max Age:" + maxAge);

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }             
    }

    class PersonImplementation
    {
        public void DisplayPerson(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("{0}\t{1}",people[i].Name,people[i].Age);
            }
        }

        public double Average(Person[] people)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0;i < people.Length;i++)
            {
                sum+=people[i].Age;
            }

            avg=sum/people.Length;

            return avg;
        }

        public int MaxAge(Person[] people)
        {
            int maxAge = 0;
            for(int i = 0;i<people.Length;i++)
            {
                if(maxAge<people[i].Age)
                {
                    maxAge=people[i].Age;
                }
            }

            return maxAge;
        }
    }
}
