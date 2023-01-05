
using ConsoleApp1;
using System;
using System.Security.Cryptography.X509Certificates;

namespace UtilizandoOO
{
    class Progam
    {
        static void Main(string[] args)
        {
         
    
            Triangulo x = new Triangulo(20, 20, 20,5); // aqui está tendo os valores que serão instanciados para o construtor

            //Console.WriteLine(x.A); Dessa forma não conseguimos ter acesso ao atributo.
            
            Console.WriteLine(x.valueA);


        }
    }
}