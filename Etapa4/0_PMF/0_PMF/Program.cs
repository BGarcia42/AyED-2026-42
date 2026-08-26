using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PMF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5, c = 2;

            SaludarA("aaaa");

            Console.WriteLine(Sumar(b, a));
            Console.WriteLine(Sumar(a, c));
            Console.WriteLine(Sumar(Sumar(b, a), Sumar(a, c)));
            Console.WriteLine(Sumar(Sumar(a, SumarDos(Sumar(c, b))), a));

            Console.ReadKey();
        }

        static void SaludarA(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        static int SumarDos(int n)
        {
            int resultado = n + 2;
            return resultado;
        }

        static int Sumar(int n, int n2)
        {
            int resultado = n + n2;
            return resultado;
        }
    }
}
