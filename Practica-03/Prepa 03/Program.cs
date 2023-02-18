using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");
            Triangulo triangulo = new Triangulo(12, 15, 16, "amarillo");
            Triangulo_Escaleno triangulo_escaleno = new Triangulo_Escaleno(7, 2, 5, 3, "rojo");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");

            Figura figura4 = triangulo;
            Figura figura5 = triangulo_escaleno;

            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();

            figura4.MostrarDatos();
            figura5.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            Console.ReadLine();
           
            
        }
    }
}
