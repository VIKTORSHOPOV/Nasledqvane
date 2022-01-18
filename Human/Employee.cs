using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Employee : Human
    {
        string firma;
        string dlujnost;
        double zaplata;

        public Employee(string name, int age, string email, string firma, string dlujnost, double zaplata) : base(name, age, email)
        {
            this.firma = firma;
            this.dlujnost = dlujnost;
            this.zaplata = zaplata;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Firma: {firma}\nDlujnost: {dlujnost}\nZaplata: {zaplata}");
        }
    }
}
