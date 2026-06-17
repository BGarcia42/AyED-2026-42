using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el tamaño de la matriz: ");
            int num = int.Parse(Console.ReadLine());
            int[,] matriz = new int[num, num];
            Random rand = new Random();

            Console.Clear();
            Console.WriteLine("Matriz:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.ReadKey();
        }
    }
}