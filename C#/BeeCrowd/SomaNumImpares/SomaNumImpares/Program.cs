using System;
using System.Numerics;

namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                for (int i = X + 1; i < Y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = Y + 1; i < X; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}