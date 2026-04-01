using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double numero = double.Parse(Console.ReadLine());
            double cuadrado_numero = Math.Pow(numero, 2);
            double cubo_numero = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado del numero es: " + cuadrado_numero);
            Console.Write("El cubo del numero es: " + cubo_numero);
            Console.ReadKey();
        }
    }
}
