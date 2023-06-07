using System;
namespace cgpaCalculation
{
    class cgpaCalculation
    {
        static void Main(string[] args) 
        {
            double course1, course2, course3, course4,averageCgpa;

            Console.Write("Cgpa of course1 :");
             course1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cgpa of course2 :");
             course2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cgpa of course3 :");
             course3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cgpa of course4 :");
             course4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("==================");
            averageCgpa = (course1 + course2+course3 + course4)/4;
            Console.WriteLine("Average cgpa is :"+Math.Round(averageCgpa,2));
            Console.ReadLine();

        }
    }
}