using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el número de estudiantes: ");
            int num = int.Parse(Console.ReadLine());
            string[,] matriz = new string[num, 3];
            Random rand = new Random();
            Console.Clear();
            for (int i = 0; i < num; i++)
            {
                matriz[i, 0] = "Pepe " + (i + 1);
                matriz[i, 1] = (rand.Next(12, 19)).ToString();
                matriz[i, 2] = (rand.Next(1, 10)).ToString();
                Console.WriteLine("Nombre: " + matriz[i, 0] + " - Edad: " + matriz[i, 1] + " - Calificación: " + matriz[i, 2]);
            }
            Console.ReadKey();
        }
    }
}
