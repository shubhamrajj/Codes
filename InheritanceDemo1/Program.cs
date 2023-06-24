using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TWO-WHEELER FEATURES");
            TwoWheeler discover=new TwoWheeler ();
            discover.ApplyBrake();
            discover.ApplyHorn();
            discover.ApplySideStand();

            Console.WriteLine("\nFOUR-WHEELER FEATURES");
            FourWheeler maruti=new FourWheeler ();
            maruti.ApplyBrake();
            maruti.ApplyHorn();
            maruti.SwitchOnAc();
            maruti.SwitchOnMusic();
        }
    }

    class Vehicle
    {
        public void ApplyBrake()
        {
            Console.WriteLine("Brake feature");
        }
        public void ApplyHorn()
        {
            Console.WriteLine("Horn feature");
        }
    }

    class FourWheeler : Vehicle
    {
        public void SwitchOnAc()
        {
            Console.WriteLine("AC feature");
        }
        public void SwitchOnMusic()
        {
            Console.WriteLine("Music feature");
        }
    }

    class TwoWheeler : Vehicle
    {
        public void ApplySideStand()
        {
            Console.WriteLine("Stand feature");
        }
    }
}
