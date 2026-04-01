using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Su nombre completo es: " + nombre + " " + apellido);
            Console.ReadKey();
        }
    }
}
