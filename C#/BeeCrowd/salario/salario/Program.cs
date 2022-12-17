using System;

namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float resultado = b * c;

            Console.WriteLine($"NUMBER = {a}");
            Console.WriteLine($"SALARY = U$ {resultado.ToString("F2")}");   
        }
    }
}