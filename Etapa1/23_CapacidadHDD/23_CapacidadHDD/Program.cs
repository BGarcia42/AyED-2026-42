using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar la cantidad de cilindros que tiene su HDD: ");
            int cilindros = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la cantidad de pistas por cilindro: ");
            int pistas = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la cantidad de sectores por pista: ");
            int sectores = int.Parse(Console.ReadLine());
            long bytes = (long)512 * sectores * pistas * cilindros;
            long kb = bytes / 1024;
            long mb = kb / 1024;
            long gb = mb / 1024;
            Console.Write("Su HDD posee una capacidad de " + kb + " KB, " + mb + " MB o " + gb + " GB.");
            Console.ReadKey();
        }
    }
}
