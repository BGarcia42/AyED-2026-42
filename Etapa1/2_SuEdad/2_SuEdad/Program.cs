using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SuEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Tenes " + edad + " años");
            Console.ReadKey();
        }
    }
}
