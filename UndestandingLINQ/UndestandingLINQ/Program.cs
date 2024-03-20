using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndestandingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=22889
            // LINQ - Language Integrated Query

            // LINQ is a set of extensions to the .NET Framework that,
            // encompass language-integrated query, set, and transform operations.

            // LINQ allows you to query data from any .NET collection, SQL database,
            // ADO.NET dataset, XML document, and many other data sources.

            // LINQ is a set of extensions to the .NET Framework that,
            // encompass language-integrated query, set, and transform operations.

            // LINQ allows you to query data from any .NET collection, SQL database,
            // ADO.NET dataset, XML document, and many other data sources.

            List<Car> myCars = new List<Car>
            {
                new Car() { Make = "BMW", Model = "550i", VIN = "C3", StickerPrice = 55000, Year = 2009 },
                new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4", StickerPrice = 35000, Year = 2010 },
                new Car() { Make = "BMW", Model = "745li", VIN = "E5", StickerPrice = 75000, Year = 2008 },
                new Car() { Make = "Ford", Model = "Escape", VIN = "F6", StickerPrice = 25000, Year = 2008 },
                new Car() { Make = "BMW", Model = "55i", VIN = "G7", StickerPrice = 57000, Year = 2010 }
            };

            // LINQ Query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            // LINQ Method
            // var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            /*
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2009));
            */
            Console.OutputEncoding = Encoding.UTF8;
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());
            var newCars = myCars.Where(p => p.Year == 2008);
            Console.WriteLine(newCars.GetType());
            Console.WriteLine(newCars.Count());

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var otherCars = from car in myCars
                            where car.Make == "BMW"
                            && car.Year == 2010
                            select new  { car.Year, car.Make };

            Console.WriteLine(otherCars.GetType());
            
            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }
            */
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year{ get; set; }
        public double StickerPrice { get; set; }
    }
}
