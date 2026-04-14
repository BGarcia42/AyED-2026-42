using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (contador < 101)
            {
                if (contador % 3 == 0)
                {
                    Console.Write("fizz");
                }
                if (contador % 5 == 0)
                {
                    Console.Write("buzz");
                }
                if (contador % 3 != 0 && contador % 5 != 0)
                {
                    Console.Write(contador);
                }
                Console.WriteLine("");
                contador += 1;
            }
            Console.ReadKey();
        }
    }
}
