using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=5281

            /*
             * This program, "Bob's Big Giveaway", is a decision-based game. 
             * It prompts the user to select a door (1, 2, or 3), 
             * and reveals a prize based on their selection.
             */


            // Welcome message for Bob's Big Giveaway game
            Console.WriteLine("Bob's Big Giveway!");

            // Prompt the user to choose a door (1, 2, or 3)
            Console.Write("Choose one door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            // Determine the prize based on the user's choice
            if (userValue == "1")         
                message = "You won a new car!";
                               
            else if (userValue == "2")
                message = "You won a new boat!";                      
            else if (userValue == "3")           
                message = "You won a new cat!";                        
            else
            {
                // Prompt the user to choose again if input is invalid
                message = "Please choose an option: 1, 2 or 3: ";
                
            }

            // Display the result to the user
            Console.WriteLine(message);

            // Add a loop to allow restarting the game
            while(true) 
            {
                // Prompt the user to start new game("Y/N")
                Console.Write("Play again? (Y/N): ");

                // Turn all chars in to lower case
                string playAgain = Console.ReadLine().Trim().ToLower();

                if (playAgain == "y")
                {
                    // clear the console before restart
                    Console.Clear();

                    // Prompt the user to choose a door (1, 2, or 3)
                    Console.Write("Choose one door: 1, 2, or 3: ");
                    userValue = Console.ReadLine();

                    // Determine the prize based on the user's choice
                    if (userValue == "1")
                        message = "You won a new car!";
                    else if (userValue == "2")
                        message = "You won a new boat!";
                    else if (userValue == "3")
                        message = "You won a new cat!";
                    else
                    {
                        // Prompt the user to choose again if input is invalid
                        message = "Please choose an option: 1, 2, or 3: ";
                        
                    }
                    // Display the result to the user
                    Console.WriteLine(message);
                }
                else if (playAgain == "n")
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break; // Exit the loop and end the program
                }
                else
                {
                    // warning to user about invalid input
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }
            }
            // Wait for user input before exiting
            Console.ReadLine();

            // Continue here: https://youtu.be/0QUgvfuKvWU?t=6629
        }
    }
}
