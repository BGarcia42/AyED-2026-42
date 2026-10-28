using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Eternauta
{
    class Program
    {
        static void Main(string[] args)
        {
            Refugio refugio101 = new Refugio(101, 20, 12);
            Refugio refugio102 = new Refugio(102, 15, 10);
            Refugio refugio103 = new Refugio(103, 30, 25);

            MostrarRefugios(refugio101, refugio102, refugio103);

            MostrarResumen(refugio101, refugio102, refugio103);

            Console.WriteLine("");
            Console.Write("Presione cualquier tecla para continuar.....");
            Console.ReadKey();
        }

        static void MostrarRefugios(Refugio refugio101, Refugio refugio102, Refugio refugio103)
        {
            Console.WriteLine("=== SISTEMA DE REFUGIOS ===");
            Console.WriteLine("");

            refugio101.MostrarInformacion();
            refugio102.MostrarInformacion();
            refugio103.MostrarInformacion();
        }

        static void MostrarResumen(Refugio refugio101, Refugio refugio102, Refugio refugio103)
        {
            Console.WriteLine("=== RESUMEN ===");
            Console.WriteLine("");

            Console.WriteLine("Personas alojadas: " + TotalRefugiados(refugio101, refugio102, refugio103));
            Console.WriteLine("Lugares disponibles: " + TotalDisponible(refugio101, refugio102, refugio103));
            Console.WriteLine("Refugio de mayor capacidad: " + MaxCapacidad(refugio101, refugio102, refugio103));
        }

        static int TotalRefugiados(Refugio refugio101, Refugio refugio102, Refugio refugio103)
        {
            return refugio101.getPersonas() + refugio102.getPersonas() + refugio103.getPersonas();
        }

        static int TotalDisponible(Refugio refugio101, Refugio refugio102, Refugio refugio103)
        {
            return refugio101.CalcularDisponibles() + refugio102.CalcularDisponibles() + refugio103.CalcularDisponibles();
        }

        static int MaxCapacidad(Refugio refugio101, Refugio refugio102, Refugio refugio103)
        {
            int a = refugio101.getCapacidad();
            int b = refugio102.getCapacidad();
            int c = refugio103.getCapacidad();
            if (a >= b && a >= c)
            {
                return 101;
            }
            else if (b >= a && b >= c)
            {
                return 102;
            }
            else
            {
                return 103;
            }
        }
    }

    class Refugio
    {
        private int codigo;
        private int capacidad;
        private int personas;

        public Refugio(int codigo, int capacidad, int personas)
        {
            this.codigo = codigo;
            this.capacidad = capacidad;
            this.personas = personas;
        }

        public int getCapacidad()
        {
            return capacidad;
        }

        public int getPersonas()
        {
            return personas;
        }

        public int CalcularDisponibles()
        {
            return capacidad - personas;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Refugio " + codigo);
            Console.WriteLine("Capacidad: " + capacidad);
            Console.WriteLine("Alojados: " + personas);
            Console.WriteLine("Disponibles: " + CalcularDisponibles());
            Console.WriteLine("");
        }
    }
}
