using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            n = int.Parse(Console.ReadLine());
            while(i < 6)
            {
                if (n%2 != 0)
                {
                    Console.WriteLine(n);
                    i++;
                }
                n++;
            }
        }
    }
}