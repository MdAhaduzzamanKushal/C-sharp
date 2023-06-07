using System;
namespace BasicInfo
{
    class BasicInfoUpdated
    {
        static void Main(string[] args)
        {
            string name, id, cgpa, department, university, course, blood, nationality, hobby, familyMember;

            Console.Write("Enter your name    :");
            name = Console.ReadLine();

            Console.Write("Enter  your  Id    :");
            id = Console.ReadLine();

            Console.Write("Enter your cgpa    :");
            cgpa = Console.ReadLine();

            Console.Write("Enter department   :");
            department = Console.ReadLine();

            Console.Write("Enter your university:");
            university = Console.ReadLine();

            Console.Write("Enter your  course  :");
            course = Console.ReadLine();

            Console.Write("Enter your blood    :");
            blood = Console.ReadLine();

            Console.Write("Enter nationality   :");
            nationality = Console.ReadLine();

            Console.Write("Enter your hobby  :");
            hobby = Console.ReadLine();
            
            Console.Write("Enter your family :");
            familyMember = Console.ReadLine();





            Console.WriteLine("--------My Info--------");
            Console.WriteLine("Name      : "+name);
            Console.WriteLine("Id         : "+id);
            Console.WriteLine("CGPA      :" +cgpa);
            Console.WriteLine("Department   : "+department);
            Console.WriteLine("University    : "+university);
            Console.WriteLine("Course      : "+course);
            Console.WriteLine("Blood       :"+blood);
            Console.WriteLine("Nationality    : "+nationality);
            Console.WriteLine("Hobby       :"+hobby);
            Console.WriteLine("FamilyMember  :"+familyMember);
            Console.WriteLine("-------------------------");
            
            Console.ReadLine();
        }
    }
}