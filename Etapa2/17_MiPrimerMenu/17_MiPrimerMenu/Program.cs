using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Boludeces que se me ocurrieron ---");
            Console.WriteLine("1. Sumar 2 + 4");
            Console.WriteLine("2. Restar 4 - 2");
            Console.WriteLine("3. Decir 'Hola profe'");
            Console.WriteLine("4. Salir");
            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("La suma de 2 + 4 es igual a 6");
                        break;
                    case 2:
                        Console.WriteLine("La resta de 4 - 2 es igual a 2");
                        break;
                    case 3:
                        Console.WriteLine("Hola profe");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                opcion = int.Parse(Console.ReadLine());
            }

        }
    }
}
