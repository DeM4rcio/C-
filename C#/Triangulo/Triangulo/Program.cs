using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            double a = double.Parse(text[0]);
            double b = double.Parse(text[1]);
            double c = double.Parse(text[2]);

            double perimetro = a + b + c;

            double area = (a + b) * c / 2.0;

            if (a < b + c && b < a + c && c < a + b)
                
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1")}" );

            else
                Console.WriteLine($"Area = {area.ToString("F1")}" );

           
        }
    }
}