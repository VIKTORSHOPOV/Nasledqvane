using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Players_and_Monsters
{
    internal class Hero
    {
        string username;
        int level;

        public string Username { get { return username; } set { username = value; } }

        public int Level { get { return level; } set { level = value; } }


        public Hero(string username, int level)
        {
            this.level = level;
            this.username = username;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }

    }
}
