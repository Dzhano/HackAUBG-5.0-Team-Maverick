using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Registering users: ");
            int num = int.Parse(Console.ReadLine());

            UserRepository rep = new UserRepository();

            for (int i = 0; i < num; i++)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                User user = new User(username, 0, 0);
                rep.AddUser(user);
            }

            /*User user1 = new User("name1", 4, 13);
            User user2 = new User("name2", 5, 25);
            User user3 = new User("name3", 2, 34);
            User user4 = new User("user4", 12, 43);

            rep.AddUser(user1);
            rep.AddUser(user2);
            rep.AddUser(user3);
            rep.AddUser(user4);*/

            foreach (var user in rep.GetAllUsers())
            {
                Console.WriteLine(user.Name + " " + user.NumGames);
            }
        }
    }
}
