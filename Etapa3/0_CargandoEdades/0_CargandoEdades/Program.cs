using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];
            Console.Write("Ingrese las edades para cada estudiante una por una: ");
            for (int i = 0; i < edades.Length; i++){
                edades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Edad del alumno " + (i + 1) + ": " + edades[i]);
            }
            Console.ReadKey();
        }
    }
}
