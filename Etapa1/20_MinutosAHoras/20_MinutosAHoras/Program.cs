using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número de minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            int horas = minutos / 60;
            int sobra = minutos % 60;
            Console.WriteLine("Eso en horas sería " + horas + " horas y " + sobra + " minutos.");
            Console.ReadKey();
        }
    }
}
