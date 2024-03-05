using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU
            /*
             * This is a simple C# console application that performs a basic arithmetic operation. Here’s how it works:
                Two integer variables, x and y, are declared.
                The variable x is assigned the value 7.
                The variable y is assigned the result of the expression x + 3. Since x is 7, y becomes 10.
                The value of y is then written to the console.
                The program waits for the user to press any key before it closes with Console.ReadLine().
             */

            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
