using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            float consumo = x / y;
            Console.WriteLine($"{consumo.ToString("F3")} km/l");

        }
    }
}