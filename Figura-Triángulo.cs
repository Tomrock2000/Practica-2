using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2
{
    public class Triángulo : Figura
    {
       
        private float _altura;
        private float _base;
      

        public Triángulo( float base_trian, float altura, string color) : base(color)
        {
           
            _altura = altura;
            _base = base_trian;
        }

        public override double GetÁrea()
        {
            return (_altura * _base) / 2;
        }
        public override double GetPerímetro()
        {
            return 3 * _base;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine("No se conoce el tipo de triángulo");
        }          
           

        
    }
}
