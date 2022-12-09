using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int cont;
            int val = 0;
            for(cont = 1; cont <= 6; cont++)
            {
                float num = float.Parse(Console.ReadLine());
                if (num > 0)
                {
                    val = val + 1;
                }

            }

            Console.WriteLine($"{val} valores postivos");


        
        }
    }
}