using System;

namespace PersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine("output");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
