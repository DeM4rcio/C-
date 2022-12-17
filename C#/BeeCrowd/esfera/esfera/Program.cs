using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            
            double volume = 4.0/3.0 * 3.14159 * Math.Pow(r,3);
            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        }
    }
}