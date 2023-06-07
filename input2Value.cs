using System;
namespace Personalinfo
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Your age :");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " You are " + age + " year old.");
            Console.ReadLine();

        
        }
    }
}