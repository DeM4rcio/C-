using System;
using System.Globalization;

namespace Bee
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            
            double A = double.Parse(text[0]);
            double B = double.Parse(text[1]);
            double C = double.Parse(text[2]);

            double Delta = Math.Pow(B, 2) - 4 * A * C;
            if (A == 0 || Delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double R1 = (-B - Math.Sqrt(Delta)) / (2*A);
                double R2 = (-B + Math.Sqrt(Delta)) / (2 * A);
                Console.WriteLine($"R1 = {R2.ToString("F5")}");
                Console.WriteLine($"R2 = {R1.ToString("F5")}");


            }


        }
        
    }
    

}