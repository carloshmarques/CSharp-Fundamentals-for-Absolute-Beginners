using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=26427

            Timer myTymer = new Timer(2000);

            myTymer.Elapsed += myTymer_Elapsed;
            myTymer.Elapsed += myTymer_Elapsed1;

            myTymer.Start();

            Console.WriteLine("Press enter to remove the timer.");
            Console.ReadLine();

            myTymer.Elapsed -= myTymer_Elapsed1;

            Console.WriteLine("Press enter to stop the timer.");
            Console.ReadLine();
        }

        private static void myTymer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void myTymer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
