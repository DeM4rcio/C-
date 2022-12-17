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
            

            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a * a == (b * b + c * c) || b * b == (a * a + c * c) || c * c == (a * a + b * b))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a * a > (b * b + c * c) || b * b > (a * a + c * c) || c * c > (a * a + b * b))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a * a < (b * b + c * c) || b * b < (a * a + c * c) || c * c < (a * a + b * b))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && a == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}