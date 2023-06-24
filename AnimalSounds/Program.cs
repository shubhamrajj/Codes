using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[10];
            animal[0] = new Dog("Boomer", 7);
            animal[1] = new Dog("Quills", 4);
            animal[2] = new Cat("Rani", 3);
            animal[3] = new Cat("King", 4);
            animal[4] = new Frog("Tade", 1);
            animal[5] = new Frog("Fro", 3);
            animal[6] = new Kitten("Mini", 1);
            animal[7] = new Kitten("Maxy", 2);
            animal[8] = new Tomcat("Tommy", 3);
            animal[9] = new Tomcat("Pam", 2);


            for (int i = 0; i < animal.Length; i++)
            {
                if (animal[i] is Dog)
                {
                    Dog d = (Dog)animal[i];
                    d.Display();
                    d.Sound();
                }
                else if (animal[i] is Cat)
                {
                    Cat c = (Cat)animal[i];
                    c.Display();
                    c.Sound();
                }
                else if (animal[i] is Frog)
                {
                    Frog f = (Frog)animal[i];
                    f.Display();
                    f.Sound();
                }
                else if (animal[i] is Kitten)
                {
                    Kitten k = (Kitten)animal[i];
                    k.Display();
                    k.Sound();
                }
                else
                {
                    Tomcat t = (Tomcat)animal[i];
                    t.Display();
                    t.Sound();
                }
            }

        }
    }
    class Animal
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animals makes sounds...");
        }
        public void Display()
        {
            Console.WriteLine("\nName of the Animal   :" + this.Name);
            Console.WriteLine("Age of the Animal    :" + this.Age);
        }
    }
    class Dog : Animal
    {
        public Dog(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
        public override void Sound()
        {
            Console.WriteLine("Dog Barks...");
        }
    }
    class Frog : Animal
    {
        public Frog(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
        public override void Sound()
        {
            Console.WriteLine("Forg Ribbits...");
        }
    }
    class Cat : Animal
    {
        public Cat(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
        public override void Sound()
        {
            Console.WriteLine("Cat Meows...");
        }
    }
    class Kitten : Animal
    {
        public Kitten(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
        public override void Sound()
        {
            Console.WriteLine("Kitten Purrs...");
        }
    }
    class Tomcat : Animal
    {
        public Tomcat(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
        public override void Sound()
        {
            Console.WriteLine("Tomcat Meows...");
        }
    }
}