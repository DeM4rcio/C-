using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0) Console.WriteLine("NULL");

            else if (x % 2 == 0 && x > 0) Console.WriteLine("EVEN POSITIVE");

            else if (x % 2 == 0 && x < 0) Console.WriteLine("EVEN NEGATIVE");

            else if (x % 2 != 0 && x > 0) Console.WriteLine("ODD POSITIVE");

            else if (x % 2 != 0 && x < 0) Console.WriteLine("ODD NEGATIVE");
            }
        }
    }
}