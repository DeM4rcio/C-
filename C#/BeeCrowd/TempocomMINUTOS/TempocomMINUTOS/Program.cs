using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            int h1 = int.Parse(text[0]);
            int m1 = int.Parse(text[1]);
            int h2 = int.Parse(text[2]);
            int m2 = int.Parse(text[3]);
          

            int  s1, s2, tempo, hr, min;

            

            if (h2 <= h1 && m2 <= m1)
            {
                h2 = h2 + 24;
            }
            else if (m2 <= m1)
            {
                m2 = m2 + 60;
                h2 = h2 - 1;
            }

            s1 = (h1 * 3600) + (m1 * 60);
            s2 = (h2 * 3600) + (m2 * 60);

            tempo = (s2 - s1);
            hr = tempo / 3600;
            min = (tempo - (hr * 3600)) / 60;
            Console.WriteLine($"O JOGO DUROU {hr} HORA(S) E {min} MINUTO(S)");
        }
    }
}