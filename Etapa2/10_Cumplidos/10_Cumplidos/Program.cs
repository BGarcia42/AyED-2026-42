using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa cuantos años tenes: ");
            int años = int.Parse(Console.ReadLine());
            int contador = 1;
            Console.WriteLine("Cumpliste: ");
            while (contador < años + 1)
            {
                Console.Write(contador);
                if (contador < años)
                {
                    Console.WriteLine("");
                }
                contador += 1;
            }
            Console.WriteLine(" años.");
            Console.ReadKey();
       }

   }
}
