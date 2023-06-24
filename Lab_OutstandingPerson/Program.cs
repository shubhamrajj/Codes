using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OutstandingPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];

            people[0] = new Student("Ravi", "Delhi", 95);
            people[1] = new Student("Raghu", "Mysore", 70);
            people[2] = new Student("Raman", "Jaipur", 98);

            people[3] = new Faculty("Alok", "Bangalore", 3);
            people[4] = new Faculty("Parmesh", "Delhi", 7);

            for (int i = 0; i < people.Length; i++)
            {
                if(people[i] is Student)
                {
                    Student s=(Student)people[i];
                    if(s.IsOutStanding())
                    {
                        s.Display();
                    }                   
                }
                else
                {
                    Faculty f=(Faculty)people[i];
                    if(f.IsOutStanding())
                    {
                        f.Display();
                    }
                }
            }

        }
    }

    abstract class Person
    {
        string name;
        string city;
        public Person(string name,string city)
        {
            this.name = name;
            this.city = city;
        }
        public abstract bool IsOutStanding();

        public virtual void Display()
        {
            Console.WriteLine("Name:" + this.name);
            Console.WriteLine("City:" + this.city);
        }
    }

    class Student : Person
    {
        int totalMarks;
        public Student(string name,string city,int totalMarks) : base(name,city)
        {
            this.totalMarks = totalMarks;
        }

        public override bool IsOutStanding()
        {
            if(totalMarks>=90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Total Marks:" + totalMarks);
        }
    }
    class Faculty : Person
    {
        int noOfBooksPublished;
        public Faculty(string name,string city,int noOfBooksPublished) : base(name,city)
        {
            this.noOfBooksPublished = noOfBooksPublished;
        }

        public override bool IsOutStanding()
        {
            if(noOfBooksPublished>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("No. of books published:" + noOfBooksPublished);
        }
    }
}
