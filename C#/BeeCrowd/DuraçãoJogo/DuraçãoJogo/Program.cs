using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            int a = int.Parse(text[0]);
            int b = int.Parse(text[1]);

            if (a >= b)
                Console.WriteLine($"O JOGO DUROU {(24 - a) + b} HORA(S)");
            else
                Console.WriteLine($"O JOGO DUROU {b - a} HORA(S)");
        }
    }
}