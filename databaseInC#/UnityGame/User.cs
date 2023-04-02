using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace UnityGame
{
    public class User
    {
        public int Id { get; set; }
        public int NumGames { get; set; }
        public int TotalPoints { get; set; }
        public string Name { get; set; }

        public User() { }

        public User(string name, int numGames, int totalPoints)
        {
            Name = name;
            NumGames = numGames;
            TotalPoints = totalPoints;
        }

        public User(int id, int numGames, int totalPoints, string name)
        {
            Id = id;
            NumGames = numGames;
            TotalPoints = totalPoints;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name + " " + TotalPoints + " " + NumGames + " " + Id);
        }
    }
}