using ConsoleApp1;
using System;
namespace Fixação { 

    class Program
    {
        static void Main(string[] args)
        {
            Pessoas x,y ;

            x = new Pessoas();
            y = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa");
            x.nome = Console.ReadLine();
            x.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa");
            y.nome = Console.ReadLine();
            y.idade = int.Parse(Console.ReadLine());

            if(y.idade < x.idade)
            {
                Console.WriteLine($"Pessoa mais velha {x.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha {y.nome}");
            }

        }
    }

}