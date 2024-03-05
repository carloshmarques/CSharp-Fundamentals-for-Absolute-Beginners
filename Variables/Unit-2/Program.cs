using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");

            string myFirstName;
            myFirstName= Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName= Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();
            // https://youtu.be/0QUgvfuKvWU?t=4382

             

        }
    }
}
