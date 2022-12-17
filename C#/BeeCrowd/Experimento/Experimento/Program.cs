using System;
using System.Numerics;

namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;
            for (int i = 0; i < N; i++)
            {
                
                string[] infos = Console.ReadLine().Split(' ');
                int Quantia = int.Parse(infos[0]);
                string Tipo = infos[1];
                
                    switch (Tipo)
                {
                    case "C": 
                        totalCoelhos += Quantia; 
                        break;
                    case "R": 
                        totalRatos += Quantia; 
                        break;
                    case "S": 
                        totalSapos += Quantia; 
                        break;
                }
            }

            int totalCobaias = totalCoelhos + totalRatos + totalSapos;
            double mediaCoelhos = (totalCoelhos * 100) / (double)totalCobaias;
            double mediaRatos = (totalRatos * 100) / (double)totalCobaias;
            double mediaSapos = (totalSapos * 100) / (double)totalCobaias;
            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelhos);
            Console.WriteLine("Total de ratos: " + totalRatos);
            Console.WriteLine("Total de sapos: " + totalSapos);
            Console.WriteLine(($"Percentual de coelhos: {mediaCoelhos.ToString("F2")} %"));
            Console.WriteLine(($"Percentual de ratos: {mediaRatos.ToString("F2")} %"));
            Console.WriteLine(($"Percentual de sapos: {mediaSapos.ToString("F2")} %"));
        }
    }
}
