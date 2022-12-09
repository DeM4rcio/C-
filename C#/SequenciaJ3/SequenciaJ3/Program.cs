using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int i = 1, j = 7;
            while (i <= 9)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                    j--;
                }
                j += 5;
                i += 2;
            }
        }
    }
}