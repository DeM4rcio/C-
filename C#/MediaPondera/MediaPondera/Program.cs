using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {

            
            int cont, numero;
            numero = int.Parse(Console.ReadLine());
            for (cont = 1; cont <= numero; cont++)
            {
                string[] text = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(text[0]);
                double nota2 = double.Parse(text[1]);
                double nota3 = double.Parse(text[2]);
                double total = nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0;
                double media = total / 10.0;
                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}