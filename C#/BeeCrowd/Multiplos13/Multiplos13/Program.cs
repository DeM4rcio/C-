using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int n1, n2, i, soma;

            
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            soma = 0;

            if (n1 < n2)
            {
                for (i = n1; i <= n2; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (i = n2; i <= n1; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);

            
        }
    }
}