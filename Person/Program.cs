using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Deep", "Durgapur", 93);
            s.IsOutstanding();
            Console.WriteLine("\n");
            Student s1 = new Student("Vikram", "Haldia", 89);
            s1.IsOutstanding();
            Console.WriteLine("\n");
            Faculty f = new Faculty("Suresh", "Kolkata", 10);
            f.IsOutstanding();
            Console.WriteLine("\n");
            Faculty f1 = new Faculty("Biplab", "Jharkhand", 5);
            f1.IsOutstanding();


        }
        class Person
        {
            string Name;
            string City;

            public Person(string Name, string City)
            {
                this.Name = Name;
                this.City = City;
            }
            public void DisplayPerson()
            {
                Console.WriteLine("Name of the Person :" + this.Name);
                Console.WriteLine("Belongs to City :" + this.City);

            }
        }
        class Student : Person
        {
            int totalmarks;
            public Student(string Name, string City, int totalmarks) : base(Name, City)
            {
                this.totalmarks = totalmarks;
            }
            public void IsOutstanding()
            {
                if (totalmarks >= 90)
                {
                    DisplayPerson();
                    Console.WriteLine("Total Marks Obtained :{0}", this.totalmarks);
                }
                else
                    Console.WriteLine("Not Eligible...");
            }
        }
        class Faculty : Person
        {
            int No_of_books_published;
            public Faculty(string Name, string City, int No_of_books_published) : base(Name, City)
            {
                this.No_of_books_published = No_of_books_published;
            }
            public void IsOutstanding()
            {
                if (No_of_books_published > 5)
                {
                    DisplayPerson();
                    Console.WriteLine("No of Books Published :{0}", this.No_of_books_published);
                }
                else
                    Console.WriteLine("Not Eligible...");
            }

        }
    }
}