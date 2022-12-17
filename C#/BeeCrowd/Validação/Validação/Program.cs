using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            float temp1 = 0;
            float temp2, number;
            int i = 0, X;

            while (true)
            {
                number = float.Parse(Console.ReadLine());

                if (number >= 0 && number <= 10)
                {
                    if (i == 1)
                    {
                        temp2 = number;
                        Console.WriteLine($"media = {((temp1 + temp2) / 2).ToString("F2")}");
                        i = 0;
                        X = int.Parse(Console.ReadLine()); ;
                        Console.WriteLine("novo calculo (1-sim 2-nao)");

                        while (X < 1 || X > 2)
                        {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            X = int.Parse(Console.ReadLine()); ;
                            if (X == 1)
                                break;
                            else if (X == 2)
                                return ;
                        }

                        if (X == 1)
                            continue;
                        else if (X == 2)
                            break;

                    }
                    else
                    {
                        temp1 = number;
                        i++;
                    }
                }
                else
                    Console.WriteLine("nota invalida");

            }
        }
    }
}