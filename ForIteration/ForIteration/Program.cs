using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=7831

            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Nº seven found:");
                    break;
                }
                // Console.WriteLine(i);
                // Continue here:  https://youtu.be/0QUgvfuKvWU?t=7931
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);

            }
            Console.ReadLine();
        }
    }
}
