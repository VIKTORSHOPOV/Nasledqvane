using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nasledqvane
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy obj = new Puppy();
            obj.Bark();
            obj.Eat();
            obj.Weep();
            
            Cat obj2 = new Cat();
            obj2.Meow();
        }

        
    }
}
