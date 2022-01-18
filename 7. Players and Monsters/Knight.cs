using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Players_and_Monsters
{
    internal class Knight : Hero
    {
        public Knight(string username, int level) : base(username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }

    internal class DarkKnight : Knight
    {
        public DarkKnight(string username, int level) : base(username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }

    internal class BladeKnight : DarkKnight
    {
        public BladeKnight(string username, int level) : base(username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
