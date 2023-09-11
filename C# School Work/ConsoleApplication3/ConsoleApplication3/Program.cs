using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userValue = "";
            while (userValue != null)
                try
            {
                
                Console.WriteLine("Please enter your birthday in the format MM/DD/YYYY and press the Enter key.");
                userValue = Console.ReadLine();   
                Console.WriteLine("You typed: " + userValue);
                DateTime userBirthday = DateTime.Parse(userValue);
                TimeSpan myAge = DateTime.Now.Subtract(userBirthday);
                Console.WriteLine("Day's Since Birthdate:  " + myAge.TotalDays); 
            }
            catch (Exception e )
            {
                Console.WriteLine("Please enter a vaild format: {0} ", e.Message);
                
                    }
            
            
            Console.ReadLine();


        }
    }
}
