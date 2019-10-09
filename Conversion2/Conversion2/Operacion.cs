using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion2
{
   public class Operacion
    {
        public double Convertir( double a, double b=100, double c=0)
        {
            double metros = a / b;
            return metros;
        }

        public double Convertir(double a, double b = 39.37)
        {
            double pulgadas = a * b;
            return pulgadas;
        }

        public double Convertir(double a)
        {
            double metros = a * 1000;
            return metros;
        }

        public double Convertir()
        {
            return 0;
        }
    }
}
