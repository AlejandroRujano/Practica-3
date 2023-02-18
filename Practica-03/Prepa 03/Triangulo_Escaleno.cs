using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    internal class Triangulo_Escaleno : Triangulo 
    {
        private float _base;
        private float _altura;
        private float _lado;
        private float _lado1;


        public Triangulo_Escaleno(float base_triangulo, float altura, float lado, float lado1, string color) : base(color)
        {
            _base = base_triangulo;
            _altura = altura;
            _lado = lado;
            _lado1 = lado1;
        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _base + _lado + _lado1;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
