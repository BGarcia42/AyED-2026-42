using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SuNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Tu nombre es " + nombre);
            Console.ReadKey();
        }
    }
}
