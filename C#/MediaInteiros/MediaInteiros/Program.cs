using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int cont;
            int val = 0;
            float media = 0;
            float resultado;
            for (cont = 1; cont <= 6; cont++)
            {
                
                float num = float.Parse(Console.ReadLine());
                if (num > 0)
                {
                    val = val + 1;

                    media += num;
                }

            }
            media = media / val;
            Console.WriteLine($"{val} valores positivos");
            Console.WriteLine($"{media.ToString("F1")}");



        }
    }
}