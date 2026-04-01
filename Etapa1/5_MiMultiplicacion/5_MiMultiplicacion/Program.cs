using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiMultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Escriba otro número para multiplicarlo con el anterior: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("La multiplicación de sus dos números es: ");
            Console.WriteLine(numero1 * numero2);
            Console.ReadKey();
        }
    }
}
