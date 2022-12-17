using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            
            int golsInter;
            int golsGremio;
            int flag = 1;
            int totalJogos = 0;
            int vitoriasGremio = 0;
            int vitoriasInter = 0;
            int empates = 0;

            while (flag == 1)
            {
                totalJogos++;             
                string[] text = Console.ReadLine().Split(' ');
                golsInter = int.Parse(text[0]);
                golsGremio = int.Parse(text[1]);
                if (golsInter > golsGremio) vitoriasInter++;
                else if (golsGremio > golsInter) vitoriasGremio++;
                else empates++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                flag = int.Parse(Console.ReadLine());
                while (flag != 1 && flag != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    flag = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(totalJogos + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);
            if (vitoriasInter > vitoriasGremio) Console.WriteLine("Inter venceu mais");

        else if (vitoriasGremio > vitoriasInter) Console.WriteLine("Gremio venceu mais");

        else Console.WriteLine("Nao houve vencedor");
        }
    }
}
