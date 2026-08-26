using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEterNota
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] refugios = new int[20, 5];
            int cantidadRefugios = 0;

            char opcion = 'j';
            do
            {
                MostrarMenu();
                opcion = Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch (opcion)
                {
                    case '1':
                        AñadirRefugio(refugios, cantidadRefugios);
                        cantidadRefugios++;
                        break;
                    case '2':
                        MostrarRefugios(refugios);
                        break;
                    case '3':
                        OcuparRefugio(refugios, cantidadRefugios);
                        break;
                    case '4':
                        // Lógica para mostrar cantidadRefugios
                        break;
                    case '5':
                        // Lógica para refugio con más suministros
                        break;
                    case '6':
                        // Lógica para promedio por zona
                        break;
                    case '7':
                        // Lógica para filtrar por zona
                        break;
                    case 'X':
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != '8');
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void AñadirRefugio(int[,] matriz, int cantidadRefugios)
        {
            int tmp = 0;
            bool encontrado = true;
            if (cantidadRefugios > 19)
            {
                Console.Clear();
                Console.WriteLine("No hay refugios... ¡Vamos a morir!");
            }
            else
            {
                while (encontrado == true)
                {
                    Console.Write("Ingresá el código del refugio. No puede ser 0 o repetido: ");
                    tmp = int.Parse(Console.ReadLine());
                    encontrado = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (tmp == 0 || matriz[i, 0] == tmp)
                        {
                            encontrado = true;
                            Console.WriteLine("El código que ingresaste ya esta siendo utilizado. Intentá de nuevo.");
                        }
                    }
                }
                matriz[cantidadRefugios, 0] = tmp;
                Console.Write("Ingresá la capacidad máxima del refugio: ");
                matriz[cantidadRefugios, 1] = int.Parse(Console.ReadLine());
                Console.Write("Ingresá la cantidad de suministros disponibles: ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 0)
                {
                    Console.Write("No se puede sobrevivir debiendo... Intentá de nuevo: ");
                    tmp = int.Parse(Console.ReadLine());
                }
                matriz[cantidadRefugios, 2] = tmp;
                Console.Write("Ingresá la zona donde está ubicado el refugio (1 es NORTE, 2 es SUR, 3 es OESTE, 4 es CENTRO): ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 1 || tmp > 4)
                {
                    Console.Write("Zona inválida, esta parte ya está perdida... Intentá de nuevo: ");
                    tmp = int.Parse(Console.ReadLine());
                }
                matriz[cantidadRefugios, 3] = tmp;
                Console.Write("¿Está ocupado el refugio? (1 es SI, 0 es NO): ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 0 || tmp > 1)
                {
                    Console.Write("La opción que ingresaste no es válida. Intentá de nuevo: ");
                    tmp = int.Parse(Console.ReadLine());
                }
                matriz[cantidadRefugios, 4] = tmp;
                Console.Clear();
                Console.WriteLine("El refugio fue registrado exitosamente.");
            }
        }

        static void MostrarRefugios(int[,] matriz)
        {
            for (int i = 0; i < 20; i++)
            {
                if (matriz[i, 0] != 0)
                {
                    Console.Write("Refugio " + (i + 1) + " - Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Zona: ");
                    if (matriz[i, 3] == 1) { Console.Write("NORTE (Congreso)"); }
                    else if (matriz[i, 3] == 2) { Console.Write("SUR (Constitución)"); }
                    else if (matriz[i, 3] == 3) { Console.Write("OESTE (Flores)"); }
                    else { Console.Write("CENTRO (Microcentro)"); }
                    Console.Write(" - Ocupado: ");
                    if (matriz[i, 4] == 1) { Console.WriteLine("SI"); }
                    else { Console.WriteLine("NO"); }
                }
            }
        }

        static void OcuparRefugio(int[,] matriz, int cantidadRefugios)
        {
            Console.Write("Elegí el refugio que queres marcar como ocupado: ");
            int eleccion = int.Parse(Console.ReadLine());
            while (eleccion < 1 || eleccion > cantidadRefugios || matriz[eleccion - 1, 4] != 0)
            {
                if (matriz[eleccion - 1, 4] != 0) { Console.Write("No somos Okupas, esto ya está ocupado. Intentá de nuevo: "); }
                else { Console.Write("Este refugio no existe. Intentá de nuevo: "); }
                eleccion = int.Parse(Console.ReadLine());
            }
            matriz[eleccion, 4] = 1;
            Console.Clear();
            Console.WriteLine("El refugio ha sido ocupado exitosamente.");
        }

        static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
            Console.WriteLine("1. Agregar refugio");
            Console.WriteLine("2. Mostrar todos los refugios");
            Console.WriteLine("3. Ocupar refugio");
            Console.WriteLine("4. Mostrar cantidadRefugios");
            Console.WriteLine("5. Refugio con más suministros");
            Console.WriteLine("6. Promedio por zona");
            Console.WriteLine("7. Filtrar por zona");
            Console.WriteLine("8. Salir");
            Console.WriteLine("");
        }
    }
}