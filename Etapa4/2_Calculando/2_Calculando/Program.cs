using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            while (true)
            {
                Console.WriteLine("-= CALCULADORA =-");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                char opcion = Console.ReadKey(true).KeyChar;
                Console.Clear();
                if (opcion == '1' || opcion == '2' || opcion == '3' || opcion == '4')
                {
                    Console.Write("Ingrese un número: ");
                    a = int.Parse(Console.ReadLine());
                    if (opcion == '1') { Console.Write("Ingrese otro número para sumarle al anterior: "); }
                    else if (opcion == '2') { Console.Write("Ingrese otro número para restarle al anterior: "); }
                    else if (opcion == '3') { Console.Write("Ingrese otro número para multiplicarle al anterior: "); }
                    else { Console.Write("Ingrese otro número para dividirle al anterior: "); }
                    b = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("El resultado es: " + Calculadora(a, b, opcion));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción incorrecta. Intente de nuevo.");
                }
                Console.WriteLine("");
            }
        }

        static int Suma(int num, int num2)
        {
            return num + num2;
        }

        static int Resta(int num, int num2)
        {
            return num - num2;
        }

        static int Multiplicacion(int num, int num2)
        {
            return num * num2;
        }

        static int Division(int num, int num2)
        {
            return num / num2;
        }

        static int Calculadora(int a, int b, char opcion)
        {
            int resultado = 0;
            switch (opcion)
            {
                case '1':
                    resultado = Suma(a, b);
                    break;

                case '2':
                    resultado = Resta(a, b);
                    break;

                case '3':
                    resultado = Multiplicacion(a, b);
                    break;

                case '4':
                    resultado = Division(a, b);
                    break;

                default:
                    break;
            }
            return resultado;
        }
    }
}
