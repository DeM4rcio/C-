using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();





            if (text == "vertebrado")
            {

                if (text1 == "ave")
                {
                    if (text2 == "carnivoro") Console.WriteLine("aguia");
                    else Console.WriteLine("pomba");
                }

                else if (text1 == "mamifero")
                {
                    if (text2 == "onivoro") Console.WriteLine("homem");
                    else Console.WriteLine("vaca");
                }

            }
            else if (text == "invertebrado")
            {

                if (text1 == "inseto")
                {
                    if (text2 == "hematofago") Console.WriteLine("pulga");
                    else Console.WriteLine("lagarta");
                }

                else if (text1 == "anelideo")
                {
                    if (text2 == "hematofago") Console.WriteLine("sanguessuga");
                    else Console.WriteLine("minhoca");
                }
            }
        }
    }
}