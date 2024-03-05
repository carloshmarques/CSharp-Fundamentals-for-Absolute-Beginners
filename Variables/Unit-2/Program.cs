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
            /*
             * This is a simple C# console application that asks for the user’s first and last name, and then greets the user by their full name. Here’s how it works:
                The program first outputs “What is your name?” to the console.
                It then prompts the user to type their first name with "Type your first name: ".
                The user’s input is read from the console and stored in the myFirstName variable.
                The program then prompts the user to type their last name with "Type your last name: ".
                The user’s input is read from the console and stored in the myLastName variable.
                Finally, the program outputs "Hello, " followed by the user’s full name, and waits for the user to press any key before it closes.
             */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");

            //string myFirstName;
            string myFirstName= Console.ReadLine();

            // string myLastName;
            Console.Write("Type your last name: ");
            string myLastName= Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();           

        }
    }
}
