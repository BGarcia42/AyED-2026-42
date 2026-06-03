using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vidasPokemones = new int[6];
            int registroPokemones = 0;
            char opcion = '0';
            int pos = 0;
            int vida = 0;
            while (opcion != 'X')
            {
                Console.WriteLine("-= CENTRO POKÉ-REMEDIO =-");
                Console.WriteLine("");
                Console.WriteLine("1. Registrar un nuevo pokémon");
                Console.WriteLine("2. Mostrar la vida de todos los pokemones");
                Console.WriteLine("3. Curar un pokémon");
                Console.WriteLine("4. Dañar un pokémon");
                Console.WriteLine("5. Curar a todos los pokemones");
                Console.WriteLine("6. Mostrar pokemones debilitados");
                Console.WriteLine("7. Mostrar el pokemón con más vida");
                Console.WriteLine("8. Mostrar el pokemón con menos vida");
                Console.WriteLine("9. Calcular promedio de vida del equipo");
                Console.WriteLine("0. Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("A. Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("B. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("C. Usar Poción Máxima");
                Console.WriteLine("X. Salir");

                ConsoleKeyInfo input = Console.ReadKey(true);
                opcion = char.ToUpper(input.KeyChar);

                switch (opcion)
                {
                    case '1':
                        if (registroPokemones < 6)
                        {
                            Console.Clear();
                            Console.Write("Ingrese la vida del Pokémon: ");
                            vidasPokemones[registroPokemones] = int.Parse(Console.ReadLine());
                            registroPokemones++;
                            while (vidasPokemones[registroPokemones - 1] > 100 || (vidasPokemones[registroPokemones - 1] < 0))
                            {
                                Console.WriteLine("");
                                Console.Write(vidasPokemones[registroPokemones - 1] + " no es un valor de vida válido. Intente de nuevo: ");
                                vidasPokemones[registroPokemones - 1] = int.Parse(Console.ReadLine());
                            }
                            Console.Clear();
                            Console.WriteLine("Pokémon registrado correctamente en la posición " + (registroPokemones - 1) + ".");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No se pueden registrar más pokemones. El centro está lleno.");
                        }
                        break;

                    case '2':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            for (int i = 0; i < registroPokemones; i++)
                            {
                                Console.Write("Pokémon " + (i + 1) + " - Vida: " + vidasPokemones[i] + " - Estado: ");
                                if (vidasPokemones[i] == 0) { Console.WriteLine("Debilitado"); }
                                else if (vidasPokemones[i] < 30) { Console.WriteLine("Crítico"); }
                                else if (vidasPokemones[i] > 90) { Console.WriteLine("Buen estado"); }
                                else { Console.WriteLine("Herido"); }
                            }
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case '3':
                        if (registroPokemones != 0)
                        {
                            Console.Clear();
                            Console.Write("Ingrese la posición del pokémon a curar: ");
                            pos = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese puntos de vida a recuperar: ");
                            vida = int.Parse(Console.ReadLine());
                            vidasPokemones[pos] += vida;
                            if (vidasPokemones[pos] > 100) { vidasPokemones[pos] = 100; }
                            Console.Clear();
                            Console.WriteLine("El pokémon en la posición " + pos + " fue curado.");
                            Console.WriteLine("Vida actual: " + vidasPokemones[pos]);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay pokemones para curar.");
                        }
                        break;

                    case '4':
                        if (registroPokemones != 0)
                        {
                            Console.Clear();
                            Console.Write("Ingrese la posición del pokémon a dañar: ");
                            pos = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese cantidad de daño: ");
                            vida = int.Parse(Console.ReadLine());
                            vidasPokemones[pos] -= vida;
                            if (vidasPokemones[pos] < 0) { vidasPokemones[pos] = 0; }
                            Console.Clear();
                            Console.WriteLine("El pokémon en la posición " + pos + " fue dañado.");
                            Console.WriteLine("Vida actual: " + vidasPokemones[pos]);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay pokemones para dañar.");
                        }
                        break;

                    case '5':
                        if (registroPokemones != 0)
                        {
                            Console.Clear();
                            Console.Write("Ingrese puntos de curación general: ");
                            vida = int.Parse(Console.ReadLine());
                            for (int i = 0; i < registroPokemones; i++)
                            {
                                vidasPokemones[i] += vida;
                                if (vidasPokemones[i] > 100) { vidasPokemones[i] = 100; }
                            }
                            Console.Clear();
                            Console.WriteLine("Todos los pokemones fueron curados.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay pokemones para dañar.");
                        }
                        break;

                    case '6':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            bool debilitados = vidasPokemones.Contains(0);
                            if (debilitados == true)
                            {
                                int cantDebilitados = 0;
                                Console.WriteLine("Pokemones debilitados:");
                                for (int i = 0; i < registroPokemones; i++)
                                {
                                    if (vidasPokemones[i] == 0)
                                    {
                                        Console.WriteLine("Pokémon en posición " + i);
                                        cantDebilitados++;
                                    }
                                }
                                Console.WriteLine("Cantidad total de debilitados: " + cantDebilitados);
                            }
                            else { Console.WriteLine("No hay pokemones debilitados."); }
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case '7':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            int maxVida = vidasPokemones.Max();
                            int maxPos = Array.IndexOf(vidasPokemones, maxVida);
                            Console.WriteLine("El pokémon con mayor vida está en la posición " + maxPos + ".");
                            Console.WriteLine("Vida: " + maxVida);
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case '8':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            int minVida = vidasPokemones.Min();
                            int minPos = Array.IndexOf(vidasPokemones, minVida);
                            Console.WriteLine("El pokémon con mayor vida está en la posición " + minPos + ".");
                            Console.WriteLine("Vida: " + minVida);
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case '9':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            Console.WriteLine("Promedio del equipo: " + vidasPokemones.Average());
                            if (vidasPokemones.Average() <= 30) { Console.WriteLine("El equipo esta en peligro."); }
                            else if (vidasPokemones.Average() >= 70) { Console.WriteLine("El equipo está en buen estado."); }
                            else { Console.WriteLine("El equipo necesita curación."); }
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case '0':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            int[] vidaMinAMax = new int[registroPokemones];
                            Array.Copy(vidasPokemones, vidaMinAMax, registroPokemones);
                            Array.Sort(vidaMinAMax);
                            Console.WriteLine("Vidas ordenadas de menor a mayor:");
                            for (int i = 0; i < registroPokemones; i++)
                            {
                                Console.Write("Pokémon ");
                                Console.Write(Array.IndexOf(vidasPokemones, vidaMinAMax[i]) + 1);
                                Console.Write(" - Vida: ");
                                Console.WriteLine(vidaMinAMax[i]);
                            }
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case 'A':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            int[] vidaMaxAMin = new int[registroPokemones];
                            Array.Copy(vidasPokemones, vidaMaxAMin, registroPokemones);
                            Array.Sort(vidaMaxAMin);
                            Array.Reverse(vidaMaxAMin);
                            Console.WriteLine("Vidas ordenadas de mayor a menor:");
                            for (int i = 0; i < registroPokemones; i++)
                            {
                                Console.Write("Pokémon ");
                                Console.Write(Array.IndexOf(vidasPokemones, vidaMaxAMin[i]) + 1);
                                Console.Write(" - Vida: ");
                                Console.WriteLine(vidaMaxAMin[i]);
                            }
                        }
                        else { Console.WriteLine("No hay pokemones para mostrar."); }
                        break;

                    case 'B':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                            Random random = new Random();
                            int daño = random.Next(5, 25);
                            Console.WriteLine("Daño recibido por todos: " + daño);
                            for (int i = 0; i < registroPokemones; i++)
                            {
                                vidasPokemones[i] -= daño;
                                if (vidasPokemones[i] < 0) { vidasPokemones[i] = 0; }
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Las vidas fueron actualizadas.");
                        }
                        else { Console.WriteLine("No hay pokemones para dañar."); }
                        break;

                    case 'C':
                        Console.Clear();
                        if (registroPokemones != 0)
                        {
                            for (int i = 0; i < registroPokemones; i++) { vidasPokemones[i] = 100; }
                            Console.WriteLine("¡Has utilizado una Poción Máxima! Se ha curado a todos los pokemones del equipo.");
                        }
                        else { Console.WriteLine("No hay pokemones para curar."); }
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
            Console.WriteLine("Gracias por utilizar el sistema del Centro Poké-Remedio.");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}
