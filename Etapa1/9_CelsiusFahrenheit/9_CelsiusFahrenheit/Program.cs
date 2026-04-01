using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura en grados centígrados: ");
            double celsius = double.Parse(Console.ReadLine());
            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Conversión a Kelvin: " + kelvin);
            Console.WriteLine("Conversión a Fahrenheit: " + fahrenheit);
            Console.ReadKey();
        }
    }
}
