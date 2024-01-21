using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Nermin";
            string result = PrintName(ad);
            Console.WriteLine(result);
        }
        static void PrintFullName(string name)
        {
            Console.WriteLine($"Your name is {name}");
        }
        static string PrintName(string name)
        {
            return $"Your name is {name}";
        }
    }
}
