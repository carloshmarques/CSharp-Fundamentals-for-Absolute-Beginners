using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=12657
            /*
            string myString = "My \"so-called\" life";
            string myString2 = "What if I need a\nnew line?";
            string myString3 = "Go to your c:\\ drive";
            string myString4 = @"Go to your c:\ drive";

            string myString5 = String.Format("{0} = {1}", "First", "Second");

            Console.OutputEncoding = Encoding.UTF8;
            string myString6 = String.Format("{0:C}", 123.45);

            string myString7 = String.Format("{0:N}", 1234567890);

            string myString8 = String.Format("{0:P}", .123);

            string myString9 = String.Format("Phone number: {0:(+###) ##-#######}", 351939133488);
            */

            //string myString = " That summer we took threes across the board ";
            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();

            }
            */

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
