using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, X, Y, i, j, sum = 0;
            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                string[] text = Console.ReadLine().Split(' ');
                X = int.Parse(text[0]);
                Y = int.Parse(text[1]);
                if (X > Y)
                {
                    for (j = Y + 1, sum = 0; j < X; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                }
                else if (X <= Y)
                {
                    for (j = X + 1, sum = 0; j < Y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}