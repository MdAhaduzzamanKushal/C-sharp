using System;
namespace madLibGames
{
    class Program
    {
        static void Main(string[] args) 
        {

            string color, pluralNoun, celebrity;

            Console.Write("Enter color :");
            color = Console.ReadLine();

            Console.Write("Type plural noun :");
            pluralNoun = Console.ReadLine();    

            Console.Write("Enter celebrety name :")
            celebrity = Console.ReadLine(); 


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun+" are blue");
            Console.WriteLine("Daiski "+ celebrity);
            Console.ReadLine();
        }
    }
}