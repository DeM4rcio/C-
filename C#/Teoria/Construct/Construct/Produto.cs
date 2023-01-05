using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangulo
    {
        private double A;
        private double B;
        private double C;
        private double Perimetro;
        public Triangulo(double a ,double b, double c) // aqui está tendo os valores recebidos pela instanciação do construtor
        {
            A= a;
            B= b;
            C= c;
        }

        public double valueA
        {
            get { return A;}
            
        }

        // podemos criar outro contrutor ( sobrecarga )

        public Triangulo(double a, double b, double c, double perimetro) 
        {
            A = a;
            B = b;
            C = c;
            Perimetro= perimetro;
        }
        public double Area() 
        {
            double area = A * B * C;
            return area;
        }
        public double Perimetr()
        {
            
            return Perimetro;
        }
    }
}