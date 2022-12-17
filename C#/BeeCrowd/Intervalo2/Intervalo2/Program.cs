using System;
using System.Numerics;

namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int z = 0;
            int w = 0;
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) z++;

            else w++;
            }
            Console.WriteLine($"{z} in");
            Console.WriteLine($"{w} out");
        }
    }
}