using System;

namespace Exercicio1101
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int X, Y;
            string[] text = Console.ReadLine().Split(' ');
            X = int.Parse(text[0]);
            Y = int.Parse(text[1]);

            while ((X  > 0 && Y > 0))
            {
                int sum = 0;
                if (X > Y)
                {
                    for (Y = Y; Y <= X; Y++)
                    {
                        sum += Y;
                        Console.WriteLine(Y + " ");
                    }
                    Console.WriteLine("Sum=" + sum + "\n");
                }
                else
                {
                    for (X = X; X <= Y; X++)
                    {
                        sum += X;
                        Console.WriteLine(X + " ");
                    }
                    Console.WriteLine("Sum=" + sum + "\n");
                }
            }
        }
    }
}