using System;

class URI
{
    static void Main(string[] args)
    {
        
        string[] x = Console.ReadLine().Split(' ');
        int a = int.Parse(x[0]);
        int b = int.Parse(x[1]);
        
        if(a == 1)
        {
            double resultado = b * 4.00;
            Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        } else if (a == 2) {
            double resultado = b * 4.50;
            Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        }else if (a == 3)
        {
            double resultado = b * 5.00;
            Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        }else if (a == 4)
        {
            double resultado = b * 2.00;
            Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        }else if (a == 5)
        {
            double resultado = b * 1.50;
            Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        }
    }
}