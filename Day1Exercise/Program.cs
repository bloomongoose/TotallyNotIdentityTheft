using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! We'll be needing some info from you today.");

            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            Console.WriteLine("Great! Please enter your age.");
            float age = float.Parse(Console.ReadLine());

            Console.WriteLine("Wonderful! Now enter your hometown.");
            string homeTown = Console.ReadLine();

            Console.WriteLine($"Your name is {name}. Your age is {age}. Your hometown is {homeTown}.");
        }
    }
}
