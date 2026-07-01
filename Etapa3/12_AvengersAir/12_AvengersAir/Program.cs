using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] asientos = new string[80, 6];
            int disponible = 80;
            int ocupado = 0;
            int primera_clase = 0;
            int economia = 0;
            int emergencia = 0;
            char opcion = '0';
            while (opcion != 'X')
            {
                Console.WriteLine("-= MENÚ AVENGERSAIR =-");
                Console.WriteLine("");
                Console.WriteLine("1. Vender asiento");
                Console.WriteLine("2. Devolver asiento");
                Console.WriteLine("3. Modificar asiento");
                Console.WriteLine("4. Calcular ventas");
                Console.WriteLine("5. Buscar pasajeros por edad");
                Console.WriteLine("6. Obtener asientos con DNI par");
                Console.WriteLine("X. Salir");
                Console.WriteLine("");
                Console.WriteLine("Asientos disponibles: " + disponible);
                Console.WriteLine("Asientos ocupados: " + ocupado);

                ConsoleKeyInfo input = Console.ReadKey(true);
                opcion = char.ToUpper(input.KeyChar);

                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        if (ocupado == 80) { Console.WriteLine("No hay asientos disponibles."); }
                        else
                        {
                            Console.WriteLine("Asientos disponibles:");
                            Console.WriteLine("");
                            for (int i = 0; i < 80; i++)
                            {
                                if (asientos[i, 0] == null)
                                {
                                    Console.Write("Asiento " + (i + 1) + " - ");
                                    if (i < 20)
                                    {
                                        Console.WriteLine("Primera clase");
                                    }
                                    else if (i + 1 > 39 && i + 1 < 44)
                                    {
                                        Console.WriteLine("Salida de emergencia");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Economía");
                                    }
                                }
                            }
                            Console.WriteLine("");
                            Console.Write("Elegí un asiento: ");
                            int n = int.Parse(Console.ReadLine());
                            while (n > 80 || n < 1)
                            {
                                Console.Write("Número de asiento inválido. Intente de nuevo: ");
                                n = int.Parse(Console.ReadLine());
                            }
                            if ((n - 1) < 20) { primera_clase += 200; }
                            else if (n > 39 && n < 44) { emergencia += 80; }
                            else { economia += 100; }
                            Console.Write("Ingresá tu nombre: ");
                            asientos[(n - 1), 0] = Console.ReadLine();
                            Console.Write("Ingresá tu apellido: ");
                            asientos[(n - 1), 1] = Console.ReadLine();
                            Console.Write("Ingresá tu edad: ");
                            asientos[(n - 1), 2] = Console.ReadLine();
                            Console.Write("Ingresá tu número de DNI: ");
                            asientos[(n - 1), 3] = Console.ReadLine();
                            Console.Write("Ingresá tu nacionalidad: ");
                            asientos[(n - 1), 4] = Console.ReadLine();
                            Console.Write("Ingrese estado de ocupación: ");
                            asientos[(n - 1), 5] = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Información cargada exitosamente.");
                            disponible -= 1;
                            ocupado += 1;
                        }
                        break;

                    case '2':
                        Console.Clear();
                        Console.Write("Ingrese el asiento que desea devolver: ");
                        int asiento = int.Parse(Console.ReadLine());
                        if (asientos[(asiento - 1), 1] == null)
                        {
                            Console.Clear();
                            Console.WriteLine("El asiento " + asiento + " no está ocupado.");
                        }
                        else
                        {
                            for (int i = 0; i < 6; i++) { asientos[(asiento - 1), i] = null; }
                            Console.Clear();
                            Console.WriteLine("El asiento ha sido devuelto exitosamente.");
                            ocupado -= 1;
                            disponible += 1;
                        }
                        break;

                    case '3':
                        Console.Clear();
                        if (ocupado == 0) { Console.WriteLine("No hay pasajeros para modificar."); }
                        else
                        {
                            Console.WriteLine("Pasajeros:");
                            Console.WriteLine("");
                            for (int i = 0; i < 80; i++)
                            {
                                if (asientos[i, 0] != null)
                                {
                                    Console.Write("Asiento " + (i + 1) + " - ");
                                    Console.Write("Nombre: " + asientos[i, 0] + " " + asientos[i, 1] + "; ");
                                    Console.Write("Edad: " + asientos[i, 2] + "; ");
                                    Console.Write("DNI: " + asientos[i, 3] + "; ");
                                    Console.Write("Nacionalidad: " + asientos[i, 4] + "; ");
                                    Console.WriteLine("Estado de ocupación: " + asientos[i, 5]);
                                }
                            }
                            Console.WriteLine("");
                            Console.Write("Elegí el asiento del pasajero a quien le vas a modificar la información: ");
                            int pasajero = int.Parse(Console.ReadLine());
                            while (asientos[(pasajero - 1), 1] == null)
                            {
                                Console.Write("Opción incorrecta. Elegí de nuevo: ");
                                pasajero = int.Parse(Console.ReadLine());
                            }
                            Console.Write("Ingrese el nombre del pasajero: ");
                            asientos[(pasajero - 1), 0] = Console.ReadLine();
                            Console.Write("Ingrese el apellido del pasajero: ");
                            asientos[(pasajero - 1), 1] = Console.ReadLine();
                            Console.Write("Ingrese la edad del pasajero: ");
                            asientos[(pasajero - 1), 2] = Console.ReadLine();
                            Console.Write("Ingrese el DNI del pasajero: ");
                            asientos[(pasajero - 1), 3] = Console.ReadLine();
                            Console.Write("Ingrese la nacionalidad del pasajero: ");
                            asientos[(pasajero - 1), 4] = Console.ReadLine();
                            Console.Write("Ingrese el estado de ocupación del pasajero: ");
                            asientos[(pasajero - 1), 5] = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Información actualizada exitosamente.");
                        }
                        break;

                    case '4':
                        int total = primera_clase + emergencia + economia;
                        Console.Clear();
                        Console.WriteLine("El vuelo ha recaudado un total de $" + total + ".");
                        break;

                    case '5':
                        Console.Clear();
                        if (ocupado == 0) { Console.WriteLine("No hay pasajeros para mostrar."); }
                        else
                        {
                            Console.Write("Ingresá la edad que querés buscar: ");
                            string edad = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Pasajeros con " + edad + " años:");
                            Console.WriteLine("");
                            for (int i = 0; i < 80; i++)
                            {
                                if (asientos[i, 2] == edad) { Console.WriteLine(asientos[i, 1] + ", " + asientos[i, 0] + " - Asiento " + (i + 1)); }
                            }
                        }
                        break;

                    case '6':
                        Console.Clear();
                        if (ocupado == 0) { Console.WriteLine("No hay pasajeros para mostrar."); }
                        else
                        {
                            Console.WriteLine("Pasajeros con DNI par:");
                            Console.WriteLine("");
                            for (int i = 0; i < 80; i++)
                            {
                                if (asientos[i, 3] != null)
                                {
                                    if (int.Parse(asientos[i, 3]) % 2 == 0) { Console.WriteLine(asientos[i, 1] + ", " + asientos[i, 0] + " - Asiento " + (i + 1)); }
                                }
                            }
                        }
                        break;

                    case 'X':
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("");
            }
            Console.Clear();
            Console.WriteLine("Gracias por utilizar el sistema de AvengersAir.");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
