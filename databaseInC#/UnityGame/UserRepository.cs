using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace UnityGame
{
    public class UserRepository
    {
        private string connectionString;

        public UserRepository()
        {
            connectionString = "server=localhost;uid=root;pwd=password;database=hackdb";
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            var connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM users";

            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            {
                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    int games = rdr.GetInt32(1);
                    int points = rdr.GetInt32(2);
                    string username = rdr.GetString(3);
                    User user = new User(id, games, points, username);
                    users.Add(user);
                }
            }
            return users;
        }
        public void AddUser(User user)
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            connection.Execute($"INSERT INTO users (username, games, points) VALUES ('{user.Name}', {user.NumGames}, {user.TotalPoints})");
        }
    }
}
