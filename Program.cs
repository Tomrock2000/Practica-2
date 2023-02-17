using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Equilátero equilátero = new Equilátero(5, 4, "Verde");
            Triángulo figura1 = equilátero;
            figura1.MostrarDatos();

            Isósceles isósceles = new Isósceles(4, 5, 7, "Azul");
            Triángulo figura2 = isósceles;
            figura2.MostrarDatos();

            Escaleno escaleno = new Escaleno(5,4,3,7,"Violeta");
            Triángulo figura3 = escaleno;
            figura3.MostrarDatos();

            Console.ReadLine();      
        }
    }
}
