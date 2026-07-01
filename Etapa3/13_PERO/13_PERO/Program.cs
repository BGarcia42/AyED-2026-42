using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            char opcion;
            int[,] misiones = new int[30, 5];
            int registro = 0;
            int proceso = 0;
            int fila = 0;
            int obj = 0;
            int total_1 = 0;
            int total_2 = 0;
            int total_3 = 0;
            int mision_1 = 0;
            int mision_2 = 0;
            int mision_3 = 0;

            do
            {
                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de pegrilo por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("X. Salir");

                ConsoleKeyInfo input = Console.ReadKey(true);
                opcion = char.ToUpper(input.KeyChar);
                Console.Clear();

                switch (opcion)
                {
                    case '1':
                        if (registro > 29) { Console.WriteLine("¡Demasiadas misiones!"); }
                        else
                        {
                            misiones[registro, 0] = registro + 1;
                            Console.Write("Ingresá el mapa en el que ocurrirá la misión:  ");
                            misiones[registro, 1] = int.Parse(Console.ReadLine());
                            while (misiones[registro, 1] < 1 || misiones[registro, 1] > 3)
                            {
                                Console.Write("Ese mapa no es de este juegazo. Intená de nuevo:");
                                misiones[registro, 1] = int.Parse(Console.ReadLine());
                            }
                            misiones[registro, 2] = rand.Next(1, 71);
                            Console.Write("Ingresá el nivel de peligro de la misión:  ");
                            misiones[registro, 3] = int.Parse(Console.ReadLine());
                            while (misiones[registro, 3] < 1 || misiones[registro, 3] > 5)
                            {
                                Console.Write("Este nivel es demasiado PEGRILOSO... Intená de nuevo:");
                                misiones[registro, 3] = int.Parse(Console.ReadLine());
                            }
                            misiones[registro, 4] = 0;
                            registro += 1;
                            Console.Clear();
                            Console.WriteLine("¡La misión fue añadida con éxito!");
                        }
                        break;

                    case '2':
                        for (int i = 0; i < 30; i++)
                        {
                            if (misiones[i, 0] != 0)
                            {
                                Console.Write("Misión " + misiones[i, 0] + " - Mapa: ");
                                if (misiones[i, 1] == 1) { Console.Write("Hagwarts"); }
                                else if (misiones[i, 1] == 2) { Console.Write("La Casa del Viejo"); }
                                else { Console.Write("El Laboratorio"); }
                                Console.Write(" - Objetos a extraer: " + misiones[i, 2] + " - Nivel de peligro: " + misiones[i, 3] + " - Estado: ");
                                if (misiones[i, 4] == 0) { Console.WriteLine("Pendiente"); }
                                else if (misiones[i, 4] == 1) { Console.WriteLine("En curso"); }
                                else { Console.WriteLine("Finalizada"); }
                            }
                        }
                        break;

                    case '3':
                        Console.Write("Elegí la misión a la que queres cambiar el estado: ");
                        int eleccion = int.Parse(Console.ReadLine());
                        while (eleccion < 1 || eleccion > registro + 1)
                        {
                            Console.Write("No elegiste una misión existente. Intentá de nuevo: ");
                            eleccion = int.Parse(Console.ReadLine());
                        }
                        if (misiones[eleccion - 1, 4] != 2)
                        {
                            misiones[eleccion - 1, 4] += 1;
                            if (misiones[eleccion - 1, 4] == 1) { proceso += 1; }
                            else if (misiones[eleccion - 1, 4] == 2) { proceso -= 1; }
                            Console.Clear();
                            Console.WriteLine("¡Se cambió el estado de la misión con éxito!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Esta misión ya está finalizada.");
                        }
                        break;

                    case '4':
                        if (proceso == 0) { Console.WriteLine("No hay misiones en proceso."); }
                        else
                        {
                            Console.WriteLine("Misiones en curso:");
                            Console.WriteLine("");
                            for (int i = 0; i < 30; i++)
                            {
                                if (misiones[i, 4] == 1)
                                {
                                    Console.Write("Misión " + misiones[i, 0] + " - Mapa: ");
                                    if (misiones[i, 1] == 1) { Console.Write("Hagwarts"); }
                                    else if (misiones[i, 1] == 2) { Console.Write("La Casa del Viejo"); }
                                    else { Console.Write("El Laboratorio"); }
                                    Console.WriteLine(" - Objetos a extraer: " + misiones[i, 2] + " - Nivel de peligro: " + misiones[i, 3]);
                                }
                            }
                        }
                        break;

                    case '5':
                        for (int i = 0; i < 30; i++)
                        {
                            if (misiones[i, 2] > obj)
                            {
                                obj = misiones[i, 2];
                                fila = i;
                            }
                        }
                        Console.Write("La misión con más objetos a extraer es: ");
                        Console.WriteLine("Misión " + misiones[fila, 0] + " - " + obj + " objetos a extraer");
                        break;

                    case '6':
                        for (int i = 0; i < 30; i++)
                        {
                            if (misiones[i, 1] == 1) { total_1 += misiones[i, 3]; mision_1 += 1; }
                            else if (misiones[i, 1] == 2) { total_2 += misiones[i, 3]; mision_2 += 1; }
                            else { total_3 += misiones[i, 3]; mision_3 += 1; }
                        }
                        float promedio_1 = total_1 / mision_1;
                        float promedio_2 = total_2 / mision_2;
                        float promedio_3 = total_3 / mision_3;
                        Console.WriteLine("Promedios de peligro según el mapa: ");
                        Console.WriteLine("");
                        Console.WriteLine("Hagwarts: " + promedio_1);
                        Console.WriteLine("La Casa del Viejo: " + promedio_2);
                        Console.WriteLine("El Laboratorio: " + promedio_3);
                        break;

                    case '7':
                        Console.Write("Ingresá el número correspondiente al mapa que querés buscar: ");
                        int mapa = int.Parse(Console.ReadLine());
                        while (mapa < 1 || mapa > 3)
                        {
                            Console.Write("Ese mapa no es de este juegazo. Intená de nuevo:");
                            mapa = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        if (mapa == 1) { Console.WriteLine("Misiones en Hagwarts:"); }
                        else if (mapa == 2) { Console.WriteLine("Misiones en La Casa del Viejo:"); }
                        else { Console.WriteLine("Misiones en El Laboratorio:"); }
                        for (int i = 0; i < 30; i++)
                        {
                            if (misiones[i, 1] == mapa)
                            {
                                Console.Write("Misión " + misiones[i, 0]);
                                Console.Write(" - Objetos a extraer: " + misiones[i, 2] + " - Nivel de peligro: " + misiones[i, 3] + " - Estado: ");
                                if (misiones[i, 4] == 0) { Console.WriteLine("Pendiente"); }
                                else if (misiones[i, 4] == 1) { Console.WriteLine("En curso"); }
                                else { Console.WriteLine("Finalizada"); }
                            }
                        }
                        break;

                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("");
            } while (opcion != 'X');
            Console.Clear();
            Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
