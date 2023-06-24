using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_UserDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            User[] users = new User[1];

            UserBO userBO = new UserBO();
            do
            {
                User u = new User();
                Console.Write("Enter Name:");
                u.Name=Console.ReadLine();
                Console.Write("Enter mobile no.:");
                u.MobileNo = long.Parse(Console.ReadLine());
                Console.Write("Enter username:");
                u.UserName = Console.ReadLine();
                Console.Write("Enter password:");
                u.Password = Console.ReadLine();
                users = userBO.Add(u, users);

                Console.WriteLine("want to add more user(y/n)?");
                choice=char.Parse(Console.ReadLine());

            } while (choice!='n');
            
            userBO.Display(users);

            string pattern;
            Console.WriteLine("Find the users staring with name\n Enter the pattern:");
            pattern = Console.ReadLine();

            int count =userBO.GetNoOfUserNameStartsWith(pattern,users);
            Console.WriteLine("Number of users found :" + count);

            
        }
    }
    class User
    {
        public string Name { get; set; }
        public long MobileNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    class UserBO
    {
        public User[] Add(User u, User[] users)
        {
            UserDAL dal = new UserDAL();
            User[] updatedUser=dal.Add(u, users);
            return updatedUser;            
        }
        public int GetNoOfUserNameStartsWith(string pattern,User[] users)
        {
            int count = 0;
            for (int i = 0; i < users.Length-1; i++)
            {
                if(users[i].Name.StartsWith(pattern))
                {
                    count++;
                }
            }
            return count;
        }

        public void Display(User[] users)
        {
            for(int i=0;i<users.Length-1;i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",i+1,users[i].Name,users[i].UserName,users[i].MobileNo,users[i].Password);
            }
        }
    }

    class UserDAL
    {
        public User[] Add(User u, User[] users)
        {
            int initalSize = users.Length;
            User user = new User { Name = u.Name, MobileNo = u.MobileNo, UserName = u.UserName, Password = u.Password };
            users[initalSize - 1] = user;

            User[] updatedUsers = new User[initalSize + 1];
            for (int i = 0; i < users.Length; i++)
            {
                updatedUsers[i] = users[i];
            }
            return updatedUsers;
        }
    }
}
