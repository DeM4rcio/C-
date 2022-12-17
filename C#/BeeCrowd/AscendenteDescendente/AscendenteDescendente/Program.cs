using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            do
            {

                string[] text = Console.ReadLine().Split(' ');
                num1 = int.Parse(text[0]);
                num2 = int.Parse(text[1]);
                if (num1 > num2)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("Crescente");
                }
            } while (num1 != num2);
        }
    }
}
