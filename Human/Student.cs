using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student : Human
    {
        int clas;

      

        public Student(string name, int age, string email, int clas) : base(name, age, email)
        {
            this.clas = clas;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Class: {clas}");
        }

    }
}
