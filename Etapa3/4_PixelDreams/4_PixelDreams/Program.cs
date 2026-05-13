using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos participantes habrá en el torneo? ");
            int[] participantes = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.Write("¿Cuántos puntos sacó el jugador " + (i + 1) + "? ");
                participantes[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(participantes);
            Array.Reverse(participantes);
            Console.Clear();
            Console.WriteLine("-= ")
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine((i + 1) + "° lugar: " + participantes[i] + " puntos");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
