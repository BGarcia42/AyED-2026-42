using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159265;
            Console.Write("Ingrese el radio de la esfera: ");
            double radio = double.Parse(Console.ReadLine());
            double superficie = 4 * pi * radio * radio;
            double volumen = 4 * pi / 3 * radio * radio * radio;
            Console.WriteLine("La superficie de su esfera es: " + superficie);
            Console.WriteLine("El volumen de su esfera es: " + volumen);
            Console.ReadKey();
        }
    }
}
