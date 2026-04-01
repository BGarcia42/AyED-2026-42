using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("presupuesto anual: ");
            double presupuesto = double.Parse(Console.ReadLine());
            double gine = (presupuesto * 40) / 100;
            double trauma = (presupuesto * 30) / 100;
            double pediatria = (presupuesto * 30) / 100;
            Console.Write("De ese presupuesto van " + gine + " para ginecología, " + trauma + " para traumatología, y " + pediatria + " para pediatría." );
            Console.ReadKey();
        }
    }
}
