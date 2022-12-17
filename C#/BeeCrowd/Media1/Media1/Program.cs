using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double resultado = ((x * 3.5) + (y * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {resultado.ToString("F5")}");

        }
    }
}