using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int h = n / 3600;
            int r = n % 3600;

            int m = r / 60;
            int s = r % 60;

            Console.WriteLine($"{h}:{m}:{s}");

        }
    }
}