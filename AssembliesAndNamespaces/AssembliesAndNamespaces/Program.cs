using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=19293

            // Write one string to a test file.
            string text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";

            // Create a directory named "TestFolder" in the user's "Public" folder.
            // Print message to console if directory already exists.
            if (System.IO.Directory.Exists(@"C:\Users\Public\TestFolder"))
            {
                Console.WriteLine("Directory already exists.");
            }
            else 
            {  
                // Prompt user to create directory if it does not exist.
                Console.WriteLine("Directory does not exist. Would you like to create it? (Y/N)");

                if (Console.ReadLine().ToUpper() == "Y")
                {
                    System.IO.Directory.CreateDirectory(@"C:\Users\Public\TestFolder");
                }
                else if (Console.ReadLine().ToUpper() == "N")
                {
                    Console.WriteLine("Directory not created.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Directory not created.");

                }
                
                // Print message to console if directory is created.
                Console.WriteLine("Directory created.");
                       
            }

            // WriteAllText creates a file, writes the specified string to the file,
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

            // Read the contents of a text file and print them to the console.
            string readText = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
            Console.WriteLine(readText);
           
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            //Console.WriteLine(reply);
            // Add new blank line to File WriteText.txt and append it with the reply from the web page.
            System.IO.File.AppendAllText(@"C:\Users\Public\TestFolder\WriteText.txt", Environment.NewLine + reply);

            // Open the file WriteText.txt with the default application.
            System.Diagnostics.Process.Start(@"C:\Users\Public\TestFolder\WriteText.txt");

            Console.ReadLine();
            // Continue here: https://youtu.be/0QUgvfuKvWU?t=19500
        }
    }
}
