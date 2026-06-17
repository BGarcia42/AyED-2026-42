using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
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
            Console.WriteLine("Matriz original:");
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

            // ordena matriz
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = temp;
                }
            }
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num / 2; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[i, num - 1 - j];
                    matriz[i, num - 1 - j] = temp;
                }
            }

            Console.WriteLine("Matriz rotada 90°:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
