using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] account = new Account[1];
            account[0] = new Account { Account_no = 8670419401, Customer_Name = "DeepSubho", Account_type = "Savings", Balance = 1000000.0 };
            Account account1 = new Account();
            Console.WriteLine("Enter Transaction type :");
            account[0].Transaction_type = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Amount :");
            double amt = double.Parse(Console.ReadLine());
            if (account[0].Transaction_type == 'D' || account[0].Transaction_type == 'd')
            {
                Console.WriteLine(account1.Debit(amt, account[0].Balance));
            }
            else if (account[0].Transaction_type == 'C' || account[0].Transaction_type == 'c')
            {
                Console.WriteLine(account1.Credit(amt, account[0].Balance));
            }


        }
        class Account
        {
            public long Account_no { get; set; }
            public string Customer_Name { get; set; }
            public string Account_type { get; set; }
            public char Transaction_type { get; set; }
            public double Balance { get; set; }

            public void DoTransaction(long accNo, string accType, char transType, double amount)
            {
                Account_no = accNo;
                Account_type = accType;
                Transaction_type = transType;

            }
            public double Credit(double amount, double balance)
            {
                double upBal = balance + amount;
                Console.WriteLine("Name :{0}", Customer_Name);
                Console.WriteLine("{0} credited to your Account", amount);
                Console.WriteLine("Update Balance :{0}", upBal);
                return upBal;
            }
            public double Debit(double amount, double balance)
            {
                double upBal = balance - amount;
                Console.WriteLine("Name :{0}", Customer_Name);
                Console.WriteLine("{0} debited from your Account", amount);
                Console.WriteLine("Updated Balance :{0}", upBal);
                return upBal;
            }
        }
    }
}