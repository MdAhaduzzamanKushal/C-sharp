using System;
namespace leapYear
{
    class leapYear
    {
        static void Main(string[] args) 
        {
            int leapYear;

            Console.Write("Enter year :");
            leapYear = Convert.ToInt32(Console.ReadLine());

            if ((leapYear % 400) == 0)
                Console.WriteLine(leapYear + " is a leap year.");
            else if ((leapYear % 100) == 0)
                Console.WriteLine(leapYear + " is not a leap year.");
            else if ((leapYear % 4) == 0)
                Console.WriteLine(leapYear + " is a leap year.");
            else
                Console.WriteLine(leapYear + " is not a leap year.");
            Console.ReadLine();
        }
    }
}