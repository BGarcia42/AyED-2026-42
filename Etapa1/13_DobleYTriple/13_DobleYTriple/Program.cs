using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double numero = double.Parse(Console.ReadLine());
            double doble_numero = numero * 2;
            double triple_numero = numero * 3;
            Console.WriteLine("El doble del numero es: " + doble_numero);
            Console.Write("El triple del numero es: " + triple_numero);
            Console.ReadKey();
        }
    }
}
