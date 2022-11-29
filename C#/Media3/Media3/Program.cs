using System;

namespace Bee
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');
            double n1 = double.Parse(notas[0]);
            double n2 = double.Parse(notas[1]);
            double n3 = double.Parse(notas[2]);
            double n4 = double.Parse(notas[3]);
            double media;
            double exame;
            double final;

            n1 = 2.0;
            n2 = 3.0;
            n3 = 4.0;
            n4 = 1.0;

            media = Math.Round((n1 + n2 + n3 + n4) / 10,1);

            if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine($"Media: {media}\nAluno em exame.");

                exame = double.Parse(Console.ReadLine());
                final = (media + exame) / 2;

                if (final >= 5.0)
                {
                    Console.WriteLine($"Nota do exame: {exame}\nAluno aprovado.\nMedia final: {final}");
                }
                else
                {
                    Console.WriteLine($"Nota do exame: {exame}\nAluno reprovado.\nMedia final: {final}");
                }

            }

            else if (media > 7.0)
            {
                Console.WriteLine($"Media: {media}\nAluno aprovado.");
            }

            else
            {
                Console.WriteLine($"Media: {media}\nAluno reprovado.");
            }

        }

    }
}
    
