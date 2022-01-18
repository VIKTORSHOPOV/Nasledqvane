using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {

        string name;
        int age;
        string email;

     


        public Human(string aname, int aage, string aemail)
        {
            name = aname;
            age = aage;
            email = aemail;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {name} \nAge: {age}\nEmail: {email}");
        }
    }
}

