using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  https://youtu.be/0QUgvfuKvWU?t=11612
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
               
            }
           

        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return  false;
            }
            else
            {
                return true;
                // displayMenu = true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool inCorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    inCorrect = false;
                else
                    Console.WriteLine("Wrong!");
            } while (inCorrect);
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);
            Console.ReadLine();
        }
    }
}
