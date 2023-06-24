using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees:");
            int n=int.Parse(Console.ReadLine());
            Userinfo[] nuser= new Userinfo[n];
            for(int i = 0; i < nuser.Length; i++)
            {
                string UseName;
                string Pass;
                string ConPass;
                string EmID;
                nuser[i]=new Userinfo();
                Console.WriteLine("Enter Name :");
                UseName=Console.ReadLine();
                Console.WriteLine("Enter Password :");
                Pass=Console.ReadLine();
                Console.WriteLine("Enter Confirm Password :");
                ConPass = Console.ReadLine();
                Console.WriteLine("Enter Email ID :");
                EmID=Console.ReadLine();
                nuser[i]=new Userinfo();
                nuser[i].RegisterUser(UseName, Pass, ConPass, EmID);
            }
            for(int i = 0; i < nuser.Length; i++)
            {
                Console.WriteLine("\nUser {0}",i+1);
                nuser[i].DisplayUserinfo();
            }
            
        }
        class Userinfo
        {
            string userName;
            string password;
            string confirm_password;
            string emailid;
            public void RegisterUser(string uN,string pwd,string conpwd,string eid )
            {
                userName = uN;  
                password = pwd; 
                confirm_password = conpwd;  
                emailid = eid;
                bool x = IsPasswordMatching();
            }
            public bool IsPasswordMatching()
            {
                if (password == confirm_password)
                {
                    return true;
                }
                return false;
            }
            public void DisplayUserinfo()
            {
                if(IsPasswordMatching()==true)
                    Console.WriteLine("\nUser Registered Successfully...");
                else
                    Console.WriteLine("\nMismatched Password,could not register user...");
            }
        }
    }
}
