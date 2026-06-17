using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de las matrices: ");
            int num = int.Parse(Console.ReadLine());
            int[,] matriz1 = new int[num, num];
            int[,] matriz2 = new int[num, num];
            int[,] matrizsuma = new int[num, num];
            Console.Clear();
            Random rand = new Random();
            Console.WriteLine("Matriz 1:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matriz1[i, j] = rand.Next(1, 100);
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Matriz 2:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matriz2[i, j] = rand.Next(1, 100);
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Suma:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matrizsuma[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write(matrizsuma[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
