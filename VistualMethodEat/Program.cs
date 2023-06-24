using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myCow = new Cow();
            Animal myLion = new Lion();
            myCow.Eat();
            myLion.Eat();
        }
    }
    abstract class Animal
    {
        public string Name;
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public abstract void Eat();

    }
    class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Lion is eating flesh...");
        }
    }
    class Cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cow is eating grass...");
        }
    }
}
