using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlRevez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese 3 letras juntas: ");
            string coso = Console.ReadLine();
            Console.Write("Sus letras al revez son: " + coso[2] + coso[1] + coso[0]);
            Console.ReadKey();
        }
    }
}
