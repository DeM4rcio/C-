using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            
            int A = int.Parse(text[0]);
            int B = int.Parse(text[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}