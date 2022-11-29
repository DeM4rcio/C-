using System;
namespace BEE 
{

    class URI
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            double A = double.Parse(text[0]);
            double B = double.Parse(text[1]);
            double C = double.Parse(text[2]);

            double tri = (A * C)/2;
            double cir = Math.Pow(C,2) * 3.14159;
            double trap = ((A + B) * C) / 2;
            double quadr = Math.Pow(B, 2);
            double reta = A * B;

            Console.WriteLine($"TRIANGULO: {tri.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {cir.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {trap.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {quadr.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {reta.ToString("F3")}");

        }
    }

}