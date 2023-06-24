using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTImplementation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                VISACard v = new VISACard();
                HPVISACard hp = new HPVISACard();
                string type;
                double amount = 0.0;
                string cardtype;

                Console.WriteLine("Enter the Transaction Details");
                Console.WriteLine("Enter Transaction type:");
                type = Console.ReadLine();
                Console.WriteLine("Enter Amount");
                amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Card Tyep:");
                cardtype = Console.ReadLine();

                if (cardtype == "VISACard")
                {
                    Console.WriteLine("Details :\n{0},{1},{2}", type, amount, cardtype);
                    Console.WriteLine("Total Reward points earned in this transaction");
                    Console.WriteLine(v.ComputeReward(type, amount));
                }
                else if(cardtype == "HPVISACard")
                {
                    if (type == "fuel")
                    {
                        Console.WriteLine("Total Reward Points Earned :\n{0},{1},{2}", type, amount, cardtype);
                        Console.WriteLine("Total Reward points earned in this transaction :");
                        Console.WriteLine(hp.ComputeReward(type, amount));
                    }
                    else
                    {
                        Console.WriteLine("Details :\n{0},{1},{2}", type, amount, cardtype);
                        Console.WriteLine("Total Reward points earned in this transaction");
                        Console.WriteLine(v.ComputeReward(type, amount));
                    }

                }
                else
                    Console.WriteLine("Invalid Input...");

                Console.WriteLine("Do you want to continue (y/n)");
                choice = char.Parse(Console.ReadLine());
            } while (choice != 'n');

            
            
        }
    }
    class VISACard
    {
        public virtual double ComputeReward(string Type,double amount)
        {
            return (0.1 * amount);
        }
    }

    class HPVISACard:VISACard
    {
        public override double ComputeReward(string Type, double amount)
        {
            return (base.ComputeReward(Type,amount))+10;
        }
    }
}
