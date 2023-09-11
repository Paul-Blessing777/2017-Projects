using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Designates my email into a variable
            string myEmail = "pblessin@kent.edu";
            // for loop adds 1 to variable myValue until it reaches limit
            for (int myValue = 0; myValue < 12; myValue++)

            // at each value the # and email are displayed
                if (myValue < 12)
                {
                    Console.WriteLine(myValue);
                    Console.WriteLine(myEmail);
                    

                }
            Console.ReadLine();
            }
    }
}
