using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas: ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, col];
            Console.Clear();
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}