using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_UserInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo[] users = new UserInfo[3];
            for (int i = 0; i < users.Length; i++)
            {
                string un, pwd, conPwd, emailid;
                Console.Write("Enter user name:");
                un=Console.ReadLine();
                Console.Write("Enter password:");
                pwd = Console.ReadLine();
                Console.Write("Confirm password:");
                conPwd = Console.ReadLine();
                Console.Write("Enter email id:");
                emailid = Console.ReadLine();

                users[i] = new UserInfo();
                users[i].RegisterUser(un,pwd,conPwd,emailid);
            }

            for (int i = 0; i < users.Length; i++)
            {
                users[i].DisplayUserInfo();
            }
        }
    }

    class UserInfo
    {
        string userName;
        string password;
        string confirm_password;
        string emailId;

        public void RegisterUser(string uname,string pwd, string conPwd, string email)
        {
            userName = uname;
            password = pwd;
            confirm_password = conPwd;
            emailId = email;
        }
        bool IsPasswordsMatching()
        {
            if(password==confirm_password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayUserInfo()
        {
            if(IsPasswordsMatching())
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("User registered succeffully");
                Console.WriteLine("User Name:" + userName);
                Console.WriteLine("Password :" + password);
                Console.WriteLine("Email Id :" + emailId);
                
            }
            else
            {
                Console.WriteLine("=======================================");               
                Console.WriteLine("User Name:" + userName);
                Console.WriteLine("Passwords are not matching, could not register user");
            }
        }


    }
}
