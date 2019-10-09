using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion2
{
   public class Converiones
    {
        public void Datos()
        {
            //Instanciar la clase operacion 
            Operacion OP = new Operacion();
            OP.Convertir();


            //Aqui se le da la opcion de que el usuario ingrese datos
            Console.WriteLine("Sea Bienvenido");
            Console.WriteLine("Conversiones de centimetros a metros, metros a pulgadas y litros a mililitros");
            Console.WriteLine("favor de ingresar los centimetros para convertir a metros");

            Console.WriteLine("Ingrese los centimetros");
            double cool = Convert.ToDouble(Console.ReadLine());
            double cool2 = 100;
            double cool3 = 0;


            double metros = OP.Convertir(cool, cool2, cool3);

            //Despliegue del resultado
            Console.WriteLine("la conversion de cm a m es:" + metros);
            Console.WriteLine("Click en enter para la siguiente conversion");
            Console.ReadKey();


            //Conversion de m a pulgadas
            Console.WriteLine("Converion de metros a pulgadas");           

            Console.WriteLine("Ingrese los metros");
            double m = Convert.ToDouble(Console.ReadLine());
            double p = 39.37;

            double pulgadas = OP.Convertir(m, p );
            //Despliegue del resultado
            Console.WriteLine("Los metros a pukgadas son :" + pulgadas);
            Console.WriteLine("Click en enter para la siguiene conversion");
            Console.ReadKey();

            //Conversion de litros a mililitros
            Console.WriteLine("Conversion de litros a mililitros");
           
            Console.WriteLine("Ingrese los litros");
            double l1 = Convert.ToDouble(Console.ReadLine());

            
            double mili = OP.Convertir(l1);

            //Despliegue del resultado
            Console.WriteLine("Los litros a mililitros son :" + mili);
            Console.ReadKey();



        }

    }
}
