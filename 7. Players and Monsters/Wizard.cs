using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Players_and_Monsters
{
    internal class Wizard : Hero
    {
        public Wizard(string username, int level) : base(username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }

    internal class DarkWizard : Wizard
    {
        public DarkWizard(string username, int level) : base(username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }

    internal class SoulMaster : DarkWizard
    {
        public SoulMaster(string username, int level) : base(username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
