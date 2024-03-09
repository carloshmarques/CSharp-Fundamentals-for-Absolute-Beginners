using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zig = " The quieter you became, the better you ear!";

            char[] charArray = zig.ToCharArray();

            Array.Reverse(charArray);
            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
