﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Eddie","Alex", "Michael", "David Lee" };
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
                         
        }
    }
}
