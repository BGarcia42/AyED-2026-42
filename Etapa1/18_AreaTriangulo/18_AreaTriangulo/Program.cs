using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base de un triángulo: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double y = double.Parse(Console.ReadLine());
            double area = (x * y) / 2;
            Console.WriteLine("El área de tu triángulo es: " + area);
            Console.ReadKey();
        }
    }
}
