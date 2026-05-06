using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializando variables
            int punt_jugador = 0;
            int punt_dealer = 0;
            int carta_actual = 0;
            int opcion = 0;
            bool activa = false;
            int victorias = 0;
            int derrotas = 0;
            bool texto = true;
            bool reglas = false;
            Random rand = null;

            // game loop
            while (opcion != 4)
            {
                if (texto == true)
                {
                    // cartas iniciales
                    if (activa == false)
                    {
                        rand = new Random();
                        punt_jugador = rand.Next(4, 21);
                        rand = new Random();
                        punt_dealer = rand.Next(4, 21);
                    }
                    activa = true;
                    // titulo
                    Console.WriteLine("-= BLACKJACK SIMPLIFICADO =-");
                    Console.WriteLine("");

                    if (activa == true)
                    {
                        // estadisticas
                        Console.WriteLine("Puntaje: " + punt_jugador);
                        Console.WriteLine("Partidas ganadas: " + victorias);
                        Console.WriteLine("Partidas perdidas: " + derrotas);
                        Console.WriteLine("");

                        // menu
                        Console.WriteLine("1. Pedir");
                        Console.WriteLine("2. Plantarse");
                        Console.WriteLine("3. Ver reglas");
                        Console.WriteLine("4. Salir");
                    }
                }

                // reglas

                if (reglas == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Pedi cartas sin pasarte del 21. Si le ganas al dealer ganaste");
                    reglas = false;
                }

                texto = true;

                if (punt_jugador < 21)
                {
                    ConsoleKeyInfo input = Console.ReadKey(true);
                    if (char.IsDigit(input.KeyChar))
                    {
                        opcion = int.Parse(input.KeyChar.ToString());
                    }
                    else
                    {
                        opcion = 20;
                    }
                }
                else
                {
                    activa = false;
                }
                Console.WriteLine("");

                if (activa == true)
                {
                    switch (opcion)
                    {
                        case 1:
                            rand = new Random();
                            carta_actual = rand.Next(1, 11);
                            punt_jugador += carta_actual;
                            if (punt_jugador < 21)
                            {
                                Console.Clear();
                            }
                            break;

                        case 2:
                            activa = false;
                            break;

                        case 3:
                            reglas = true;
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            texto = false;
                            break;
                    }
                }

                // chequeo puntos
                if (punt_jugador > 20)
                {
                    activa = false;
                }

                // turno dealer
                if (activa == false && punt_jugador < 22)
                {
                    while (punt_dealer < 17)
                    {
                        rand = new Random();
                        carta_actual = rand.Next(1, 11);
                        punt_dealer += carta_actual;
                    }
                }

                // quien gana
                if (activa == false)
                {
                    if (punt_jugador > 21)
                    {
                        Console.WriteLine("Te pasaste con " + punt_jugador);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Puntaje dealer: " + punt_dealer);
                    Console.WriteLine("");
                    if ((punt_dealer > punt_jugador && punt_dealer < 22) || punt_jugador > 21)
                    {
                        Console.WriteLine("Perdiste");
                        derrotas++;
                    }
                    else if (punt_dealer == punt_jugador || (punt_dealer > 21 && punt_jugador > 21))
                    {
                        Console.WriteLine("Empate");
                    }
                    else if (punt_dealer < punt_jugador || punt_dealer < 21 || (punt_dealer > punt_jugador && punt_dealer > 21))
                    {
                        Console.WriteLine("¡Ganaste!");
                        victorias++;
                    }
                    punt_dealer = 0;
                    punt_jugador = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Presiona cualquier tecla para jugar de nuevo.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }
    }
}