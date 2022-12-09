using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int cont1 = int.Parse(num[0]);

            int cont2 = int.Parse(num[1]);

            int cont3 = int.Parse(num[2]);

            if (cont1 < cont2)

            {

                int comparador = cont1;

                cont1 = cont2;

                cont2 = comparador;

            }

            if (cont2 < cont3)

            {

                int comparador = cont2;

                cont2 = cont3;

                cont3 = comparador;

            }

            if (cont1 < cont2)

            {

                int comparador = cont1;

                cont1 = cont2;

                cont2 = comparador;

            }
            Console.WriteLine($"{cont3}\n{cont2}\n{cont1}\n\n{num[0]}\n{num[1]}\n{num[2]}\n");
        }
    }
}