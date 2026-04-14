using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador < numero + 1)
            {
                if(contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador += 1;
            }
            Console.ReadKey();
        }
    }
}
