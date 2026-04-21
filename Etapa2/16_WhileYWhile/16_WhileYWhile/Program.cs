using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.Write("Números impares del 0 al 100: ");
            while (contador < 101)
            {
                if (contador % 2 != 0)
                {
                    if (contador > 98)
                    {
                        Console.WriteLine(contador);
                    }
                    else
                    {
                        Console.Write(contador + ", ");
                    }
                }
                contador += 1;
            }
            Console.WriteLine("");

            contador = 0;
            Console.Write("Números pares del 0 al 100: ");
            while (contador < 101)
            {
                if (contador % 2 == 0)
                {
                    if (contador > 98)
                    {
                        Console.WriteLine(contador);
                    }
                    else
                    {
                        Console.Write(contador + ", ");
                    }
                }
                contador += 1;
            }
            Console.WriteLine("");

            contador = 0;
            Console.Write("Números del 0 al 100: ");
            while (contador < 101)
            {
                if (contador > 99)
                {
                    Console.WriteLine(contador);
                }
                else
                {
                    Console.Write(contador + ", ");
                }
                contador += 1;
            }
            Console.WriteLine("");

            contador = 100;
            Console.Write("Números del 100 al 0: ");
            while (contador > -1)
            {
                if (contador < 1)
                {
                    Console.WriteLine(contador);
                }
                else
                {
                    Console.Write(contador + ", ");
                }
                contador -= 1;
            }
            Console.WriteLine("");

            contador = 0;
            Console.Write("Múltiplos de 3 del 0 al 100: ");
            while (contador < 101)
            {
                if (contador % 3 == 0)
                {
                    if (contador > 98)
                    {
                        Console.WriteLine(contador);
                    }
                    else
                    {
                        Console.Write(contador + ", ");
                    }
                }
                contador += 1;
            }
            Console.WriteLine("");

            contador = 0;
            Console.Write("Múltiplos de 3 y 2 del 0 al 100: ");
            while (contador < 101)
            {
                if (contador % 3 == 0 && contador % 2 == 0)
                {
                    if (contador > 95)
                    {
                        Console.WriteLine(contador);
                    }
                    else
                    {
                        Console.Write(contador + ", ");
                    }
                }
                contador += 1;
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
