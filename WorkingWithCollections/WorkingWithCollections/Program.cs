using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=21531

            /*
            Car car1 = new Car();          
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";
            
            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Title = "Microsoft .NET XML Web Services";
            b1.Author = "Nancy Davish";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            // ArrayList are dynamically sized, resizeable array
            // cool features: can add, remove, sort, and search
            // can store multiple data types
            // slower than regular arrays
            // can be useful when you don't know the size of the collection
            // or when you need to add or remove items from the middle of the collection
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T> 
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            // Dictionary<TKey, TValue>
            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            //Object initializer
            // No need to call the constructor
            /*
            Car car1 = new Car() 
            { 
                Make = "BMW",
                Model = "750li", 
                VIN = "C3" 
            };

            Car car2 = new Car()
            {
                Make = "Toyota",
                Model = "4Runner",
                VIN = "D4"
            };
            */

            // Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5" },
                new Car { Make = "Nissan", Model = "Altima", VIN = "F6" }
            };           
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
