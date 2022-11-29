using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int x = Int32.Parse(num1);
            int y = Int32.Parse(num2);

            Console.WriteLine($"X = { x + y}");
        }
    }
}