using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=10173      
            Console.WriteLine("The Name Game");
          
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
          
            Console.Write("What is your city of birth? ");
            string cityOfBirth = Console.ReadLine();

            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(cityOfBirth)); 
            
            Console.ReadLine();
            
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);         
        }

        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCityOfBirth)
        {
            Console.Write("Results: ");
            Console.Write(string.Format("{0} {1} {2}", 
                               reversedFirstName, 
                               reversedLastName,                                                                                        
                               reversedCityOfBirth));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }   

    }
}
