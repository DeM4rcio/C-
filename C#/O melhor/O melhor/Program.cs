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
            int C = int.Parse(text[2]);

            int AB = (A + B + Math.Abs(A- B))/2;
            int AC = (A + C + Math.Abs(A - C)) / 2;

            Console.WriteLine($"{Math.Max(AB, C)} eh o maior");
        }
    }
}