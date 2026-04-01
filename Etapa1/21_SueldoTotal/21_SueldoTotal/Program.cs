using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas que trabajó: ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cuanto le pagan por hora: ");
            double salario = double.Parse(Console.ReadLine());
            double sueldo = horas * salario;
            Console.WriteLine("Su sueldo total es de: " + sueldo);
            Console.ReadKey();
        }
    }
}
