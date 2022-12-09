using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            double i, j, valor;

            int temp, temp2;

            for (i = 0, j = 1, valor = 0, temp = 0, temp2 = 0; i <= 2.0; j++)
            {
                if (temp2 == 0)
                {
                    Console.WriteLine($"I={i.ToString("F0")} J={j.ToString("F0")}");
                }
                else
                {
                    Console.WriteLine($"I={i.ToString("F1")} J={j.ToString("F1")}");
                }
                temp++;

                if (temp == 3)
                {

                    i += 0.2;

                    valor += 0.2;

                    j = valor;

                    temp = 0;

                    temp2++;
                }
                if (temp2 == 5)

                    temp2 = 0;
            }
        }
    }
}