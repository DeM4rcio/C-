<<<<<<< HEAD
﻿using Static_Members;
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
=======
﻿using Static_Members;
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
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            Idade(x.idade, y.idade);

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
>>>>>>> 11f689489d61788b6c43f43fbf2f34132c99e14d
}