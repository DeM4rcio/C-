using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            string[] text = Console.ReadLine().Split(' ');
            x = int.Parse(text[0]);
            y = int.Parse(text[1]);
            if (x == 0 || y == 0)
            {
                return ;
            }

            while (x != 0 || y != 0)
            {

                if (x > 0 && y > 0)
                {
                   Console.WriteLine("primeiro");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                string[] text1 = Console.ReadLine().Split(' ');
                x = int.Parse(text1[0]);
                y = int.Parse(text1[1]);

                if (x == 0 || y == 0)
                {
                    return ;
                }
            }
        }
    }
}