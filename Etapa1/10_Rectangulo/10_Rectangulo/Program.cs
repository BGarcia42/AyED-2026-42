using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ancho de su rectángulo: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el alto de su rectángulo: ");
            double y = double.Parse(Console.ReadLine());
            double area = x * y;
            double perimetro = x * 2 + y * 2;
            double diagonal = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));
            Console.WriteLine("El area de su rectángulo es: " + area);
            Console.WriteLine("El perímetro de su rectángulo es: " + perimetro);
            Console.WriteLine("La diagonal de su rectángulo es: " + diagonal);
            Console.ReadKey();
        }
    }
}
