using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el tamaño del bloque 1:");
            int tamaño1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tamaño del bloque 2:");
            int tamaño2 = int.Parse(Console.ReadLine());

            int[] bloque1 = new int[tamaño1];
            int[] bloque2 = new int[tamaño2];


            Console.WriteLine("Ingrese los números del bloque 1:");
            for (int i = 0; i < bloque1.Length; i++)
            {
                bloque1[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Ingrese los números del bloque 2:");
            for (int i = 0; i < bloque2.Length; i++)
            {
                bloque2[i] = int.Parse(Console.ReadLine());
            }

            int mayor1 = bloque1[0];
            for (int i = 1; i < bloque1.Length; i++)
            {
                if (bloque1[i] > mayor1)
                {
                    mayor1 = bloque1[i];
                }
            }

            int mayor2 = bloque2[0];
            for (int i = 1; i < bloque2.Length; i++)
            {
                if (bloque2[i] > mayor2)
                {
                    mayor2 = bloque2[i];
                }
            }

     
            Console.WriteLine("El mayor del bloque 1 es: " + mayor1);
            Console.WriteLine("El mayor del bloque 2 es: " + mayor2);

            Console.ReadKey();
        }
    }
}