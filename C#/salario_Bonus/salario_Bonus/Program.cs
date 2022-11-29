using System;

namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double comissao = b + (c * 15/100);

            
            Console.WriteLine($"TOTAL = R$ {comissao.ToString("F2")}");
        }
    }
}