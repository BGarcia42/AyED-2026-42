using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribí una palabra: ");
            string palabra = Console.ReadLine();
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine(palabra);
                contador += 1;
            }
            Console.ReadKey();
        }
    }
}
