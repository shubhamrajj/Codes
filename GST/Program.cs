using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, type;
            double cpd;
            int nod;
            Console.WriteLine("Enter the Event Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day:");
            cpd = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of days:");
            nod = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of Event :\n1.Exhibition\n2.StageEvent");
            type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Console.WriteLine("Enter the No of Stalls :");
                    int stalls = int.Parse(Console.ReadLine());
                    Exhibition ex = new Exhibition(name, type, cpd, nod, stalls);
                    double T1 = ex.totalCost();
                    ex.Display();
                    break;
                case "2":
                    Console.WriteLine("Enter the no of Seats:");
                    int seats = int.Parse(Console.ReadLine());
                    StageEvent se = new StageEvent(name, type, cpd, nod, seats);
                    double T2 = se.totalCost();
                    se.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;


            }
        }
    }
    abstract class Event
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double CostperDay { get; set; }
        public int noOfDays { get; set; }
        public Event(string Name, string Type, double CostperDay, int noOfDays)
        {
            this.Name = Name;
            this.Type = Type;
            this.CostperDay = CostperDay;
            this.noOfDays = noOfDays;
        }
        public virtual double totalCost()
        {
            return 0;
        }
        public virtual void Display()
        {
            Console.WriteLine("Event Details :");
            Console.WriteLine("Name :" + this.Name);

            Console.WriteLine("Cost per Day :" + this.CostperDay);
            Console.WriteLine("No of Days :" + this.noOfDays);
        }
    }
    class Exhibition : Event
    {
        static int gst = 5;
        int noOFStalls;
        public Exhibition(string Name, string Type, double Costperday, int noOfDays, int noOFStalls) : base(Name, Type, Costperday, noOfDays)
        {
            this.noOFStalls = noOFStalls;
        }
        public override double totalCost()
        {
            double Totalamount = 0;
            Totalamount = (noOfDays * CostperDay);
            double gstAmount = (gst * Totalamount) / 100.0;
            double Total = gstAmount + Totalamount;
            return Total;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Type : Exhibition");
            Console.WriteLine("No of Stalls :" + this.noOFStalls);
            Console.WriteLine("Total Cost :" + totalCost());
        }

    }
    class StageEvent : Event
    {
        static int gst = 15;
        int noOFSeats;
        public StageEvent(string Name, string Type, double CostperDay, int noOFDays, int noOFSeats) : base(Name, Type, CostperDay, noOFDays)
        {
            this.noOFSeats = noOFSeats;
        }
        public override double totalCost()
        {
            double Totalamount = (noOfDays * CostperDay);
            double gstAmount = (gst * Totalamount) / 100.0;
            double Total = gstAmount + Totalamount;
            return Total;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Type : StageEvent");
            Console.WriteLine("No of Stalls :" + this.noOFSeats);
            Console.WriteLine("Total Cost   :{0}", totalCost());
        }
    }
}