using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetailsManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] user = new User[1];
            UserBO userBO = new UserBO();
            char choice;
            bool exit = false;
            int i = 0;
            do
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Add User\n2. Display All User\n3. Exit\nEnter your Choice");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        do
                        {
                            i++;
                            User u = new User();
                            Console.WriteLine("Enter User Details {0}", (i));
                            Console.WriteLine("Enter the name :");
                            u.Name = Console.ReadLine();
                            Console.WriteLine("Enter the Mobile Number :");
                            u.Mobile_number = long.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Username :");
                            u.Username = Console.ReadLine();
                            Console.WriteLine("Enter the password :");
                            u.Password = Console.ReadLine();
                            user = userBO.Add(u, user);
                            Console.WriteLine("Want to add more Users(y/n) :");
                            choice = char.Parse(Console.ReadLine());


                        } while (choice != 'n');
                        Console.WriteLine("User created Successfully...");
                        break;
                    case 2:
                        userBO.Display(user);
                        break;
                    case 3:
                        exit = true;
                        Console.WriteLine("Exited...");
                        break;
                }
            } while (exit != true);



        }
        class User
        {
            public string Name { get; set; }
            public long Mobile_number { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
        class UserBO
        {
            public User[] Add(User u, User[] user)
            {
                UserDAL dal = new UserDAL();
                User[] updatedUser = dal.Add(u, user);
                return updatedUser;
            }
            public void Display(User[] user)
            {
                Console.WriteLine("User Details:");
                Console.WriteLine("ID\tName\tMobile Number\tUsername\tPassword");
                Console.WriteLine("---------------------------------------------------------");
                for (int i = 0; i < user.Length - 1; i++)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}", i + 1, user[i].Name, user[i].Mobile_number, user[i].Username, user[i].Password);
                }
            }
        }
        class UserDAL
        {
            public User[] Add(User u, User[] user)
            {
                int initalSize = user.Length;
                User users = new User { Name = u.Name, Mobile_number = u.Mobile_number, Username = u.Username, Password = u.Password };
                user[initalSize - 1] = users;

                User[] updatedUsers = new User[initalSize + 1];
                for (int i = 0; i < user.Length; i++)
                {
                    updatedUsers[i] = user[i];
                }
                return updatedUsers;
            }
        }

    }
}