using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número para sumarle al anterior: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Suma(a, b));
            Console.ReadKey(); 
        }

        static int Suma(int num, int num2)
        {
            return num + num2;
        }
    }
}
