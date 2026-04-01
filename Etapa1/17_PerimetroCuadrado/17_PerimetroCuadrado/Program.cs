using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado de un rectangulo: ");
            double lado = double.Parse(Console.ReadLine());
            double perimetro = lado * 4;
            double superficie = Math.Pow(lado, 2);
            Console.WriteLine("El perimetro de su rectangulo es: " + perimetro);
            Console.WriteLine("La superfice de su rectangulo es: " + superficie);
            Console.ReadKey();
        }
    }
}
