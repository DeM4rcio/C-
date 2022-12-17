using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            c = 0; d = 0;

            while (true)

            {

                if (d == 2)

                    break;

                a = double.Parse(Console.ReadLine());

                if (a >= 0 && a <= 10)

                {

                    d++;

                    c += a;

                }

                else

                    Console.WriteLine("nota invalida");

            }

            b = c / 2.00;

            Console.WriteLine($"media = {b}");

        }
    }
}