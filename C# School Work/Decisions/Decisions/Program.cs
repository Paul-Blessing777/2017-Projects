using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Please wrtie something and press the Enter key");
            //    string userValue;
            //    userValue = Console.ReadLine();
            //    Console.WriteLine("you typed: " + userValue);
            //    Console.ReadLine();
            //
            Console.WriteLine("Would you prefer whats behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
            }

            else if (userValue == "2")
                message = "You get a fish!";

            else if (userValue == "3")
                message = "You get nothing!";

            else
                message = "Sorry that input is incorrect";
        

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
