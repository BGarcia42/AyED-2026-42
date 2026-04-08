using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso;
            Console.WriteLine("Escribe tu peso: ");
            peso = int.Parse(Console.ReadLine());

            if (peso >= 77)
            {
                Console.WriteLine("puedes inscribirte al torneo");
            }
            else
            { 
                Console.WriteLine("no cumples con el peso minimo, no puedes inscribirte");
            }


            Console.ReadKey();
        }
    }
}
