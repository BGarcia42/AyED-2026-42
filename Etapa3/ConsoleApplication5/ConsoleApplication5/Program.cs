using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
     
                string[] campos =
                {
            "Nombre",
            "Creador",
            "Desarrollador",
            "Versión Inicial",
            "Modelo",
            "Lenguaje",
            "S.O",
            "Licencia"
        };
            Console.Write("¿Cuántas bases de datos quiere ingresar?: ");
            int filas = int.Parse(Console.ReadLine());

            string[,] basesDatos = new string[filas, 8];


            for (int fila = 0; fila < filas; fila++)
            {
                Console.WriteLine("base de datos  " + (fila + 1));

                for (int columna = 0; columna < 8; columna++)
                {
                    Console.Write(campos[columna] + ": ");
                    basesDatos[fila, columna] = Console.ReadLine();
                }
            }
            
            Console.WriteLine("datos ingresados");

            for (int fila = 0; fila < filas; fila++)
            {
                Console.WriteLine("base de datos  " + (fila + 1));

                for (int columna = 0; columna < 8; columna++)
                {
                    Console.WriteLine(campos[columna] + ": " + basesDatos[fila, columna]);
                }

 

            }
            Console.ReadKey();
        }
    }

}
