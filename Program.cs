using System;

namespace Assignment_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Enter your name here:");
            person.Name = Console.ReadLine();

            Console.Write("Enter your age here");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is {0} and age is{1}", person.Name, person.Age);

        }
    }
}







