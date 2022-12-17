using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangulo
    {
        public double A; // aqui são os atributos da classe
        public double B;
        public double C;

        public double Area() // Aqui é o método da classe, no caso uma função de retorno
        {
            return A * B * C;
        }
    }
}
