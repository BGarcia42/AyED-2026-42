using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mate
    {
        // atributos
        private double altura;
        private int capacidad;
        private double radio;
        private bool tiene_bombilla;
        private int patas;
        private bool tiene_manija;
        private string material;
        private int cant_agua = 0;

        // constructor
        public Mate(double altura, int capacidad, double radio, bool tiene_bombilla, int patas, bool tiene_manija, string material)
        {
            this.altura = altura;
            this.capacidad = capacidad;
            this.radio = radio;
            this.tiene_bombilla = tiene_bombilla;
            this.patas = patas;
            this.tiene_manija = tiene_manija;
            this.material = material;
        }

        // metodos
        public void cebar()
        {
            cant_agua = capacidad;
        }

        public void tomar(int cantidad)
        {
            cant_agua -= cantidad;
            if (cant_agua < 0) { cant_agua = 0; }
        }

        public int getCantAgua()
        {
            return cant_agua;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mate mateFran = new Mate(10, 70, 4, true, 0, false, "Quebracho");

            Console.WriteLine("Cantidad de agua: " + mateFran.getCantAgua());
            mateFran.cebar();
            Console.WriteLine("Cantidad de agua: " + mateFran.getCantAgua());
            mateFran.tomar(20);
            Console.WriteLine("Cantidad de agua: " + mateFran.getCantAgua());

            Mate mateRojo = new Mate(11, 60, 3, false, 3, false, "Vidrio");

            Mate mateChico = new Mate(7.5, 30, 1, true, 0, true, "Aluminio");

            Mate matePablo = new Mate(8, 50, 2.5, false, 0, false, "Ceramica");

            Mate mateCopa = new Mate(10, 60, 1, false, 0, false, "Aluminio");

            Mate mateRaro = new Mate(9, 55, 1, true, 3, true, "Aluminio");

            Console.ReadKey();
        }
    }
}
