using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos productos compró durante el Hot Sale? ");
            int[] cant = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < cant.Length; i++)
            {
                Console.Write("¿Cuanto te salió el producto " + (i + 1) + "? ");
                cant[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(cant);
            Console.Clear();
            Console.WriteLine("El producto más barato que compraste te salió $" + cant[0]);
            Console.WriteLine("El producto más caro que compraste te salió $" + cant[cant.Length - 1]);
            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
