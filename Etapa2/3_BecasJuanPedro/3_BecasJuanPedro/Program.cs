using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            double edad = double.Parse(Console.ReadLine());
            Console.Write("Ingrese sus ingresos mensueales: ");
            double ingresos = double.Parse(Console.ReadLine());
            if (edad > 19 && ingresos <= 100000 || edad < 19 && ingresos == 0 || edad == 19 && ingresos <= 50000 ) {
                Console.WriteLine("Podes tener la beca");
                  }
                else
            { Console.WriteLine("No podes tener la beca");
                  }
            Console.ReadKey();
        }
    }
}
