using System;

namespace project1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computer";
            string produto2 = "Office table";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preco é $ {preco2}");
            Console.WriteLine("\n");
            Console.WriteLine($"Registro: {idade}, código {codigo} e gênero: {genero}");
            Console.WriteLine("\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            
        }
    }
}