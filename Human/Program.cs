using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student("Ivan", 14, "Ivanbg@abv.bg", 20);
            st.ShowInfo();
            Console.WriteLine();
            Thread.Sleep(1500);
            Employee em = new Employee("Gosho", 30, "Gecata12@gmail.com", "Firma", "Shef", 5000);
            em.ShowInfo();


        }
    }
}
