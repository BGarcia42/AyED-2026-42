using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá tu nombre: ");
            string nombre = Console.ReadLine();
            Saludar(nombre);
            Console.ReadKey();
        }

        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);        
        }
    }
}
