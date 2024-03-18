using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=14831
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make, 
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //decimal value = determineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.determineMarketValue());
            Console.ReadLine();
        }

        private static decimal determineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            /* Someday i migth look up the car 
             * online and get the right value */
            return carValue;
        }   
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal determineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }
    }
}
