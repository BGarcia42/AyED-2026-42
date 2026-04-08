using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura en grados celsius: ");
            int temperatura = int.Parse(Console.ReadLine());
            if(temperatura > 99)
            {
                Console.WriteLine("Hierve");
            }
            if (temperatura < 1)
            {
                Console.WriteLine("Se congela");
            }
            if (temperatura > 0 && temperatura < 100)
            {
                Console.WriteLine("Esta en estado líquido");
            }
            Console.ReadKey();
        }
    }
}
