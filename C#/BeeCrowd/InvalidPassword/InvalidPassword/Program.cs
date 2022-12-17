using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 1;

            while (numero != 2002)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    return;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}