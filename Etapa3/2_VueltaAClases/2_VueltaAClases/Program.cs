using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            int total_exam = 0;
            int tp_aprobado = 0;
            Console.Write("¿Cuantos TP tenes en la materia? ");
            int[] tp = new int[int.Parse(Console.ReadLine())];
            Console.Write("¿Cuantos exámenes tenes en la materia? ");
            int[] exam = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < tp.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del TP " + (i + 1) + ": ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 0 || tmp > 10)
                {
                    Console.WriteLine("Nota invalida, debe ser un número entre 0 y 10. Intente de nuevo: ");
                    tmp = int.Parse(Console.ReadLine());
                }
                tp[i] = tmp;
            }
            for (int i = 0; i < exam.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del exámen " + (i + 1) + ": ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 0 || tmp > 10)
                {
                    Console.WriteLine("Nota invalida, debe ser un número entre 0 y 10. Intente de nuevo: ");
                    tmp = int.Parse(Console.ReadLine());
                }
                exam[i] = tmp;
                total_exam += tmp;
            }
            Console.Clear();
            int promedio_exam = total_exam / exam.Length;
            for (int i = 0; i < tp.Length; i++)
            {
                if (tp[i] >= 6)
                {
                    tp_aprobado++;
                }
            }
            tmp = tp_aprobado * 100;
            float porc_tp_aprobado = tmp / tp.Length;
            Console.WriteLine("Tu promedio en los exámenes es de " + promedio_exam + " y aprobaste un " + porc_tp_aprobado + "% de los TPs");
            Console.WriteLine("");
            if (promedio_exam >= 6 && porc_tp_aprobado >= 75)
            {
                Console.WriteLine("¡Aprobaste la materia!");
            }
            else
            {
                Console.WriteLine("No aprobaste la materia");
            }
            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
