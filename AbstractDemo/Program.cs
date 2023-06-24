using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AbstractAccount obj;


            obj = new SavingsAccount();
            obj.Deposit(1000);
            Console.WriteLine("Amount deposited in Savings Account");
            obj.DisplayBalance();
            obj.Withdraw(500);
            Console.WriteLine("Amount withdrawn from Savings Account");
            obj.DisplayBalance();



            obj = new CurrentAccount();
            obj.Deposit(5000);
            Console.WriteLine("Amount deposited in Current Account");
            obj.DisplayBalance();
            obj.Withdraw(100);
            Console.WriteLine("Amount withdrawn from Current Account");
            obj.DisplayBalance();


        }
    }

    abstract class AbstractAccount
    {
        protected int balance;
        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);

        public void DisplayBalance()
        {
            Console.WriteLine("Current balance:" + balance);
        }
    }
    class SavingsAccount : AbstractAccount
    {        
        public override void Deposit(int amount)
        {
            this.balance += amount;
        }
        public override void Withdraw(int amount)
        {
            this.balance -= amount;
        }
    }
    class CurrentAccount : AbstractAccount
    {
       
        public override void Deposit(int amount)
        {
            this.balance += amount;
        }
        public override void Withdraw(int amount)
        {
            this.balance -= amount;
        }
    }
}
