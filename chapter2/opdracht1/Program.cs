using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam: ");
            string name = Console.ReadLine();
            Console.Write("geef je leeftijd: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + name);
            Console.WriteLine("je bent " + age + " jaar oud");

        }
    }
}
