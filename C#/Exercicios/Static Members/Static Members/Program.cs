using Static_Members;
using System;
using System.Runtime.CompilerServices;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas x = new Pessoas();
            Pessoas y= new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            Pessoas.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoas.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            Pessoas.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoas.idade = int.Parse(Console.ReadLine());

            Idade(Pessoas.idade, Pessoas.idade);

        }

        static void Idade(int idade1 ,int idade2)
        {
            if (idade1 > idade2)
            {
                Console.WriteLine(idade1);
            }
            else
            {
                Console.WriteLine(idade1);
            }
        }
    }
}