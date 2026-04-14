using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int año = int.Parse(Console.ReadLine());
            if (año % 4 == 0)
            {
                Console.WriteLine("El año es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
            }
            Console.ReadKey();
        }
    }
}
