using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int n;
            int aux = 0;
            int pos = 0;

            for (int i = 0; i < 100; i++)
            {
                 n = int.Parse(Console.ReadLine());
                if (n > aux)
                {
                    aux = n;
                    pos = i;
                }
            }

            Console.WriteLine(aux);
            Console.WriteLine(pos+1);
        }
    }
}