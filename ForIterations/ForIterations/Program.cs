using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
    //Name: Paul Blessing
    //Class: Programming Theory and Applications
    //Date Started: 2/1/16
    //Last Update: 2/1/16 5:30 p.m
{
    class Program
    {
        static void Main(string[] args)
        {
            // Designates my email as a variable
            string myEmail = "pblessin@kent.edu";
            // for loop adds 1 to variable myValue until it reaches limit
            for (int myValue = 0; myValue < 12; myValue++)

                // at each value the # and email are found
                if (myValue < 12)
                {
                    Console.WriteLine(myValue);
                    Console.WriteLine(myEmail);
                }
            // displays results
            Console.ReadLine();
        }
    }
    }
