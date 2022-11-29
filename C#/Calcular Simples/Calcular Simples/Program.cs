using System;

namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            int A1 = int.Parse(linha1[0]);
            int A2 = int.Parse(linha1[1]);
            double A3 = double.Parse(linha1[2]);

            string[] linha2 = Console.ReadLine().Split(' ');
            int B1 = int.Parse(linha2[0]);
            int B2 = int.Parse(linha2[1]);
            double B3 = double.Parse(linha2[2]);

            double total = A2 * A3 + B2 * B3;
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");

        }
    }
}