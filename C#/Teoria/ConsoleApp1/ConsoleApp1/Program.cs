using ConsoleApp1;
using System;
namespace UtilizandoOO
{
    class Progam
    {
        static void Main(string[] args)
        {
            Triangulo x, y; // Aqui estou definindo as variáveis que estarão de referência a minha classe

            x = new Triangulo(); // criação das variáveis
            y = new Triangulo();

            // podemos acessar os metodos trazendo sua referencia, exemplo:

            x.A = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"O valor do lado A é: {x.A}");

            // trazendo um exemplo mais completo, vamos calcular a área do triangulo

            Console.WriteLine("Digite o Lado A:");
            x.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Lado B:");
            x.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Lado B:");
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor de sua área é:{x.Area()}"); // aqui estou trazendo referncia ao resultado do metodo área
        }
    }
}