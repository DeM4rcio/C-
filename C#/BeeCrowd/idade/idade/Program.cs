using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            int anos = idade / 365;
            int saldo = idade - anos * 365;

            int meses = saldo / 30;
            int dias = saldo - meses*30;

            
            

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");

        }
    }
}