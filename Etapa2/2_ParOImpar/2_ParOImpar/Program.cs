using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0) {
                Console.WriteLine("El número es par.");
            }
            else {
                Console.WriteLine("El número es impar.");
            }
            Console.ReadKey();
        }
    }
}
