using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese 3 números. Acá el primero: ");
            double numero0 = double.Parse(Console.ReadLine());
            Console.Write("Acá el segundo: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Acá el tercero: ");
            double numero2 = double.Parse(Console.ReadLine());
            double suma = numero0 + numero1 + numero2;
            double promedio = suma / 3;
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
