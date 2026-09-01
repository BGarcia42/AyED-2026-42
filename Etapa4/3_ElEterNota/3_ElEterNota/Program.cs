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
                char input = Console.ReadKey(true).KeyChar;
                opcion = char.ToLower(input);
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
                        MostrarOcupados(refugios);
                        break;
                    case '5':
                        MaxSuministros(refugios);
                        break;
                    case '6':
                        CapacidadPromedio(refugios);
                        break;
                    case '7':
                        FiltrarRefugios(refugios);
                        break;
                    case 'x':
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 'x');
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
            Console.WriteLine("Refugios:");
            Console.WriteLine("");
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
            matriz[eleccion - 1, 4] = 1;
            Console.Clear();
            Console.WriteLine("El refugio ha sido ocupado exitosamente.");
        }

        static void MostrarOcupados(int[,] matriz)
        {
            Console.WriteLine("Refugios ocupados:");
            Console.WriteLine("");
            for (int i = 0; i < 20; i++)
            {
                if (matriz[i, 4] != 0)
                {
                    Console.Write("Refugio " + (i + 1) + " - Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Zona: ");
                    if (matriz[i, 3] == 1) { Console.WriteLine("NORTE (Congreso)"); }
                    else if (matriz[i, 3] == 2) { Console.WriteLine("SUR (Constitución)"); }
                    else if (matriz[i, 3] == 3) { Console.WriteLine("OESTE (Flores)"); }
                    else { Console.WriteLine("CENTRO (Microcentro)"); }
                }
            }
        }

        static void MaxSuministros(int[,] matriz)
        {
            int max = 0;
            int fila = matriz.GetLength(0);
            int col = matriz.GetLength(1);

            for (int i = 0; i < fila - 1; i++)
            {
                for (int j = 0; j < fila - i - 1; j++)
                {
                    if (matriz[j, 2] < matriz[j + 1, 2])
                    {
                        for (int k = 0; k < col; k++)
                        {
                            int tmp = matriz[j, k];
                            matriz[j, k] = matriz[j + 1, k];
                            matriz[j + 1, k] = tmp;
                        }
                    }
                }
            }
            max = matriz[0, 2];
            Console.WriteLine("Refugio(s) con más suministros:");
            Console.WriteLine("");
            for (int i = 0; i < 20; i++)
            {
                if (matriz[i, 2] == max)
                {
                    Console.Write("Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Zona: ");
                    if (matriz[i, 3] == 1) { Console.Write("NORTE (Congreso)"); }
                    else if (matriz[i, 3] == 2) { Console.Write("SUR (Constitución)"); }
                    else if (matriz[i, 3] == 3) { Console.Write("OESTE (Flores)"); }
                    else { Console.Write("CENTRO (Microcentro)"); }
                    Console.Write(" - Ocupado: ");
                    if (matriz[i, 4] == 1) { Console.WriteLine("SI"); }
                    else { Console.WriteLine("NO"); }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Nota: Si aparecen multiples refugios, es porque tienen la misma cantidad de recursos.");
        }

        static void CapacidadPromedio(int[,] matriz)
        {
            int norte = 0;
            int sur = 0;
            int oeste = 0;
            int centro = 0;
            int promedio = 0;
            int total_norte = 0;
            int total_sur = 0;
            int total_oeste = 0;
            int total_centro = 0;
            int total = 0;
            int ref_norte = 0;
            int ref_sur = 0;
            int ref_oeste = 0;
            int ref_centro = 0;
            int ref_total = 0;

            for (int i = 0; i < 20; i++)
            {
                if (matriz[i, 0] != 0) { total += matriz[i, 1]; ref_total += 1; }
                if (matriz[i, 3] == 1) { total_norte += matriz[i, 1]; ref_norte += 1; }
                else if (matriz[i, 3] == 2) { total_sur += matriz[i, 1]; ref_sur += 1; }
                else if (matriz[i, 3] == 3) { total_oeste += matriz[i, 1]; ref_oeste += 1; }
                else if (matriz[i, 3] == 4) { total_centro += matriz[i, 1]; ref_centro += 1; }
            }

            if (ref_norte != 0) { norte = total_norte / ref_norte; }
            if (ref_sur != 0) { sur = total_sur / ref_sur; }
            if (ref_oeste != 0) { oeste = total_oeste / ref_oeste; }
            if (ref_centro != 0) { centro = total_centro / ref_centro; }
            if (ref_total != 0) { promedio = total / ref_total; }

            Console.WriteLine("Capacidad promedio: " + promedio + " personas.");
            Console.WriteLine("Promedio zona NORTE (Congreso): " + norte + " personas.");
            Console.WriteLine("Promedio zona SUR (Constitución): " + sur + " personas.");
            Console.WriteLine("Promedio zona OESTE (Flores): " + oeste + " personas.");
            Console.WriteLine("Promedio zona CENTRO (Microcentro): " + centro + " personas.");
        }

        static void FiltrarRefugios(int[,] matriz)
        {
            bool encontrado = false;
            Console.WriteLine("Zona NORTE (Congreso):");
            Console.WriteLine("");
            for (int j = 0; j < 20; j++)
            {
                if (matriz[j, 3] == 1) { encontrado = true; }
            }
            if (encontrado == false) { Console.WriteLine("No se han encontrado refugios en esta zona..."); }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 3] == 1)
                    {
                        Console.Write("Refugio " + (i + 1) + " - Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Ocupado: ");
                        if (matriz[i, 4] == 1) { Console.WriteLine("SI"); }
                        else { Console.WriteLine("NO"); }
                    }
                }
            }
            Console.WriteLine("");

            encontrado = false;
            Console.WriteLine("Zona SUR (Constitución):");
            Console.WriteLine("");
            for (int j = 0; j < 20; j++)
            {
                if (matriz[j, 3] == 2) { encontrado = true; }
            }
            if (encontrado == false) { Console.WriteLine("No se han encontrado refugios en esta zona..."); }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 3] == 2)
                    {
                        Console.Write("Refugio " + (i + 1) + " - Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Ocupado: ");
                        if (matriz[i, 4] == 1) { Console.WriteLine("SI"); }
                        else { Console.WriteLine("NO"); }
                    }
                }
            }
            Console.WriteLine("");

            encontrado = false;
            Console.WriteLine("Zona OESTE (Flores):");
            Console.WriteLine("");
            for (int j = 0; j < 20; j++)
            {
                if (matriz[j, 3] == 3) { encontrado = true; }
            }
            if (encontrado == false) { Console.WriteLine("No se han encontrado refugios en esta zona..."); }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 3] == 3)
                    {
                        Console.Write("Refugio " + (i + 1) + " - Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Ocupado: ");
                        if (matriz[i, 4] == 1) { Console.WriteLine("SI"); }
                        else { Console.WriteLine("NO"); }
                    }
                }
            }
            Console.WriteLine("");

            encontrado = false;
            Console.WriteLine("Zona CENTRO (Microcentro):");
            Console.WriteLine("");
            for (int j = 0; j < 20; j++)
            {
                if (matriz[j, 3] == 4) { encontrado = true; }
            }
            if (encontrado == false) { Console.WriteLine("No se han encontrado refugios en esta zona..."); }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 3] == 4)
                    {
                        Console.Write("Refugio " + (i + 1) + " - Código: " + matriz[i, 0] + " - Capacidad máxima: " + matriz[i, 1] + " - Suministros disponibles: " + matriz[i, 2] + " - Ocupado: ");
                        if (matriz[i, 4] == 1) { Console.WriteLine("SI"); }
                        else { Console.WriteLine("NO"); }
                    }
                }
            }
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
            Console.WriteLine("X. Salir");
            Console.WriteLine("");
        }
    }
}