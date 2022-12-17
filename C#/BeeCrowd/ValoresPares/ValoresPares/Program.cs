using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            int cont;
            int val = 0;
            int contPar = 0;
            int contImpar = 0;
            int contPositivos = 0;
            int contNegativos = 0;
            

            for (cont = 1; cont <= 5; cont++)
            {

                float num = float.Parse(Console.ReadLine());
                if (num%2 == 0)
                {
                    contPar += 1;

                    
                }else 
                {
                    
                    contImpar += 1;

                }
                if (num > 0)
                {
                    contPositivos += 1;


                }else if (num < 0)
                {
                    contNegativos += 1;
                }

                

            }
            
            Console.WriteLine($"{contPar} valor(es) par(es)");
            Console.WriteLine($"{contImpar} valor(es) impar(es)");
            Console.WriteLine($"{contPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{contNegativos} valor(es) negativo(s)");





        }
    }
}