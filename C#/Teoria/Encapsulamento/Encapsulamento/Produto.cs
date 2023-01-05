using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangulo
    {
        // O encapsulamento é definido a partir dos atributos criados pela sintaxe private
        private double _a; // a forma de escrita muda pelo padrão do C#
        private double _b;
        private double _c;
        private double _perimetro;
        public Triangulo(double a, double b, double c) 
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public Triangulo(double a, double b, double c, double perimetro)
        {
            _a = a;
            _b = b;
            _c = c;
            _perimetro = perimetro;
        }
        public double Area()
        {
            double area = _a * _b * _c;
            return area;
        }
        public double Perimetr()
        {

            return _perimetro;
        }
    }
}