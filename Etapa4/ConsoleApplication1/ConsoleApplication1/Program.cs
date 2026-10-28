using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mate mateFran = new Mate(200, 4, 10, "Madera", true, true);

            mateFran.Cebar();
            mateFran.Tomar(20);

            Mate matePorcelana = new Mate(220, 4, 10, "Porcelana", false, false);

            matePorcelana.Cebar();
            matePorcelana.Tomar(20);

            Mate mateForrado = new Mate(200, 4, 10, "Vidrio y forrado de plastico", false, false);

            mateForrado.Cebar();
            mateForrado.Tomar(20);

            Mate mateChico = new Mate(60, 2, 6, "Acero", false, false);

            mateChico.Cebar();
            mateChico.Tomar(20);
        }
    }
    class Mate
    {
        //Atributos
        private int Capacidad;
        private int Radio;
        private int Alto;
        private string Material;
        private bool estaLaqueado;
        private bool tieneBombilla;
        private int cantAgua = 0;

        //Constructor
        public Mate(int Capacidad, int Radio, int Alto, string Material, bool estaLaqueado, bool tieneBombilla)
        {
            this.Capacidad = Capacidad;
            this.Radio = Radio;
            this.Alto = Alto;
            this.Material = Material;
            this.estaLaqueado = estaLaqueado;
            this.tieneBombilla = tieneBombilla;
        }
        
        //Métodos
        public void Cebar()
        {
            cantAgua = Capacidad;
        }
        public void Tomar(int cantidad)
        {
            cantAgua -= cantidad;
            if(cantAgua < 0)
            {
                cantAgua = 0;
            }
        }
    }
}
