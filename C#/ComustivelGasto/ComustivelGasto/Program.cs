using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double distancia = x * y / 12;
            Console.WriteLine(distancia.ToString("F3"));

        }
    }
}