using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número positivo entero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuenta regresiva: ");
            while (numero != -1)
            {
                Console.WriteLine(numero);
                numero -= 1;
            }
            Console.ReadKey();
        }
    }
}
