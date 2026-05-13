using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos invitados hay? ");
            int tmp = int.Parse(Console.ReadLine());
            int comida_total = 0;
            int[] invitados = new int[tmp];
            for (int i = 0; i < invitados.Length; i++)
            {
                Console.Write("¿Cuanta comida consume el invitado " + (i + 1) + "? ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 1 || tmp > 100)
                {
                    Console.Write(tmp + " no es un valor válido. Eliga un valor entre 1 y 100: ");
                    tmp = int.Parse(Console.ReadLine());
                }
                invitados[i] = tmp;
                comida_total += tmp;
            }
            int promedio = comida_total / invitados.Length;
            Console.WriteLine("");
            Console.WriteLine("Cada invitado come, en promedio, " + promedio);
            Console.WriteLine("");
            Console.WriteLine("Presiona C para mostrar cuanto come cada invitado, cualquier otra tecla para continuar.");
            ConsoleKeyInfo input = Console.ReadKey(true);
            if (input.Key == ConsoleKey.C)
            {
                Console.Clear();
                for (int i = 0; i < invitados.Length; i++)
                {
                    Console.WriteLine("El invitado " + (i + 1) + " come " + invitados[i]);
                }
                Console.WriteLine("Cada invitado come, en promedio, " + promedio);
                Console.WriteLine("");
                Console.WriteLine("Presiona cualquier tecla continuar.");
                Console.ReadKey();
            }
        }
    }
}
