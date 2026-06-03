using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese el tamaño de los bloques");
            int tamaño1 = int.Parse(Console.ReadLine());
            int tamaño2 = int.Parse(Console.ReadLine());

            int[][] notas;
           
            for (int i = 0; i < notas.Length; i++)
            { 
                for ( int j= 0; j < notas[i].Length;j++)
                {
                    Console.Write("{0}", notas[i][j]);
                }
                Console.WriteLine();
           }
            Console.ReadLine();
       }
   }
}

