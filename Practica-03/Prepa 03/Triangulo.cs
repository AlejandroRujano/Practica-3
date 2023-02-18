using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo : Figura
    {
        private float _base;
        private float _altura;
        private float _lado;
 

        public Triangulo(float base_triangulo, float altura, float lado, string color) : base(color)
        {
            _base = base_triangulo;
            _altura = altura;
            _lado = lado;
        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _base + _lado + _lado;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
