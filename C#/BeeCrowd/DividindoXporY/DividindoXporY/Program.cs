using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int X, Y;
            for (int i = 0; i < N; i++)
            {
                string[] text = Console.ReadLine().Split(' ');
                X = int.Parse(text[0]);
                Y = int.Parse(text[1]);
                if (Y == 0) Console.WriteLine("divisao impossivel");

            else Console.WriteLine(((double)X / Y).ToString("F1"));
            }
        }
    }
}