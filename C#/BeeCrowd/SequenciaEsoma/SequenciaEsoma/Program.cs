using System;

namespace Exercicio1101
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int soma = 0;
            int i, j;
            while (true) {
                string[] text = Console.ReadLine().Split(' ');
                int M = int.Parse(text[0]);
                int N = int.Parse(text[1]);
                if (M <= 0 || N <= 0)
                {
                    break;
                }

                if(M < N)
                {
                    for(i = M; i <= N; i++)
                    {
                        Console.Write(i+" ");
                        soma += i;
                    }
                    Console.WriteLine($"Sum={soma}");
                    soma = 0;
                }
                if (N < M)
                {
                    for (j = N; j <= M; j++)
                    {
                        Console.Write(j+" ");
                        soma += j;
                    }
                    Console.WriteLine($"Sum={soma}");
                    soma = 0;
                }
            }
            
        }   
    }
}
    