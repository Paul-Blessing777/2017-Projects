using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime userDay = DateTime.Parse("9/3/1994");
            //DateTime userDate = DateTime.Now;
            //TimeSpan theDate = DateTime.Now.Subtract(userDay);


            //Console.WriteLine(userDay);
            //Console.WriteLine("Days since");
            //Console.WriteLine(theDate.);
            //Console.ReadLine();


            //working with dates 
            DateTime today = new DateTime.Now;

            DateTime myBirthday = new DateTime(1969, 12, 7);
            //OR 
            //DateTime myBirthday = DateTime.Parse("12/7/1969"); 

            Console.WriteLine(myBirthday.ToString());
            Console.WriteLine(myBirthday.ToShortDateString());

            //user input  
            string userValue;
            Console.WriteLine("Please enter your birthday in the format MM/DD/YYYY and press the Enter key.");

            userValue = Console.ReadLine();
            Console.WriteLine("You typed: " + userValue);

            //conversion of a user string value to the DateTome format
            DateTime userBirthday = DateTime.Parse(userValue);

            //calculating the difference in days between today's date and user birthday   
            TimeSpan myAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();


        }
    }
}
