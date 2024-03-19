using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    internal class Program
    {
        private static string k = ""; // global scope
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=18208

            string j = "";
            // simple for loop to demonstrate scope
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                    Console.WriteLine("l is in scope here: " + l);
                }
                //Console.WriteLine(l); // l is out of scope
            }
            Console.WriteLine("The last value of j is: " + j);
            Console.WriteLine("The last value of k is: " + k);

            MyMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();         
        }
        static void MyMethod()
        {
            Console.WriteLine("The last value of k is: " + k);
        }
    }
   class Car
   {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello, World!";
        }
   }
}
