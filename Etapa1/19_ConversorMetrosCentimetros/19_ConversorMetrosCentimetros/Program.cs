using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una medida en metros: ");
            double metro = double.Parse(Console.ReadLine());
            double centimetros = metro * 100;
            double milimetros = metro * 1000;
            Console.WriteLine("Su medida en metros es igual a " + centimetros + " cm y " + milimetros + " mm.");
            Console.ReadKey();
        }
    }
}
