using System;
namespace BEE
{
    class URI
    {
        static void Main(string[] args)
        {
            
            
            
            int num = int.Parse(Console.ReadLine());
            
            for (int cont = 1 ; cont <= num; cont++)
            {        
                if (cont % 2 != 0)
                {
                    Console.WriteLine(cont);
                }
                                   
            }            
          
        }
    }
}