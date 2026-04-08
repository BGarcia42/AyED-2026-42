using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud de 3 lados de un triángulo. Acá el primero: ");
            float lado1 = float.Parse(Console.ReadLine());
            Console.Write("Acá el segundo: ");
            float lado2 = float.Parse(Console.ReadLine());
            Console.Write("Acá el tercero: ");
            float lado3 = float.Parse(Console.ReadLine());
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es equilátero.");
            }
            if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado2 != lado1))
            {
                Console.WriteLine("Es isósceles.");
            }
            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("Es escaleno.");
            }
            Console.ReadKey();
        }
    }
}
