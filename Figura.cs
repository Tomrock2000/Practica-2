using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2
{
    public abstract class Figura
    {
        private string _color;

        public Figura(string color)
        {
            _color = color;

        }
        public abstract double GetÁrea();
        public abstract double GetPerímetro();
        public abstract void MostrarDatos();

        public string GetColor()
        {
            return _color;
        }
        
    }
}