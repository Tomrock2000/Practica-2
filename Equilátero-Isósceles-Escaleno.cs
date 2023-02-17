using Práctica_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2
{
    public class Equilátero : Triángulo
    {
        

        public Equilátero(float altura, float base_trian, string color) : base(altura, base_trian, color)
        {
            
        }
        public override double GetÁrea()
        {
            return base.GetÁrea();
        }
        public override double GetPerímetro()
        {
            return base.GetPerímetro();
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un Triángulo Equilátero de color {GetColor()}, Área {GetÁrea()} y Perímetro {GetPerímetro()}");
        }
    }


    public class Isósceles : Triángulo
    {
        private float _ladoab;
        private float _ladoc;

        public Isósceles( float base_trian, float ladoc, float altura, string color) : base(altura, base_trian, color)
        {
            _ladoab = base_trian;
            _ladoc = ladoc;
        }
        public override double GetÁrea()
        {
            return base.GetÁrea();
        }
        public override double GetPerímetro()
        {
            return 2 * _ladoab + _ladoc;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un Triángulo Isósceles de color {GetColor()}, Área {GetÁrea()} y Perímetro {GetPerímetro()}");
        }
    }

    public class Escaleno : Triángulo
    {
        private float _ladoa;
        private float _ladob;
        private float _ladoc;

        public Escaleno(float base_trian, float ladob, float ladoc, float altura, string color) : base(altura, base_trian, color)
        {
            _ladoa = base_trian;
            _ladob = ladob;
            _ladoc = ladoc;
        }
        public override double GetÁrea()
        {
            return base.GetÁrea();
        }
        public override double GetPerímetro()
        {
            return _ladoa + _ladob + _ladoc;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un Triángulo Escáleno de color {GetColor()}, Área {GetÁrea()} y Perímetro {GetPerímetro()}");
        }
    }

}