using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double resultado = ((x * 2) + (y * 3)+ (z * 5))  / 10;

            Console.WriteLine($"MEDIA = {resultado.ToString("F1")}");

        }
    }
}