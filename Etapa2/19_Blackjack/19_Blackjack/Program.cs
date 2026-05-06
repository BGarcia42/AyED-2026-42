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
                            Console.Clear();
                            Console.WriteLine("============= REGLAS DEL BLACKJACK =============");
                            Console.WriteLine("El jugador compite contra la computadora, que actúa como dealer.");
                            Console.WriteLine("El objetivo es acercarse lo más posible a 21 puntos sin pasarse.");
                            Console.WriteLine("Cada carta suma puntos al puntaje total del jugador o del dealer.");
                            Console.WriteLine("Si el jugador supera los 21 puntos, pierde la partida automáticamente.");
                            Console.WriteLine("Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del dealer.");
                            Console.WriteLine("El dealer debe pedir cartas automáticamente mientras tenga menos de 17 puntos.");
                            Console.WriteLine("Cuando el dealer llega a 17 puntos o más, se planta.");
                            Console.WriteLine("Si el dealer supera los 21 puntos, gana el jugador.");
                            Console.WriteLine("Si ninguno se pasa de 21, gana quien tenga el puntaje más alto.");
                            Console.WriteLine("Si ambos terminan con el mismo puntaje, la partida queda empatada.");
                            Console.WriteLine("================================================");
                            Console.WriteLine("");
                            Console.WriteLine("Presione cualquier tecla para salir");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            texto = false;
                            break;
                    }
                }
                if (punt_jugador == 21)
                {
                    Console.Clear();
                    Console.WriteLine("-= BLACKJACK SIMPLIFICADO =-");
                    Console.WriteLine("");
                    Console.WriteLine("Puntaje: " + punt_jugador);
                    Console.WriteLine("Partidas ganadas: " + victorias);
                    Console.WriteLine("Partidas perdidas: " + derrotas);
                    Console.WriteLine("");
                    Console.WriteLine("1. Pedir");
                    Console.WriteLine("2. Plantarse");
                    Console.WriteLine("3. Ver reglas");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("");
                }

                // chequeo puntos
                if (punt_jugador > 21)
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