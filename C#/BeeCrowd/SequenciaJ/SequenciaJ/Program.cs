using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (int j = 60; j >= 0; j--)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 4;
            }
        }
    }
}