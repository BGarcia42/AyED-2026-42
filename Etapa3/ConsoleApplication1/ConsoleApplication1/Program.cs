using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
    static void Main()
        {
            int energia = 50;
            int comida = 30;
            int refugio = 0;
            int opcion = 0;

            Console.WriteLine("SOBREVIVIENDO A LA ISLA ");

            while (opcion != 6 && energia > 0 && comida > 0)
            {

                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Comida: " + comida);

                if (refugio == 1)
                {
                    Console.WriteLine("Tienes refugio");
                }
                else
                {
                    Console.WriteLine("No tienes refugio");
                }

                Console.WriteLine("1 - Buscar comida");
                Console.WriteLine("2 - Explorar la isla");
                Console.WriteLine("3 - Construir refugio");
                Console.WriteLine("4 - Encender fogata");
                Console.WriteLine("5 - Descansar");
                Console.WriteLine("6 - Salir");

                Console.Write("Elige una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Buscaste comida y encontraste frutas");
                        comida += 20;
                        energia -= 10;
                        break;

                    case 2:
                        Console.WriteLine("Exploraste la isla y encontraste materiales.");
                        energia -= 15;
                        break;

                    case 3:
                        if (refugio == 0)
                        {
                            Console.WriteLine("Construiste un refugio");
                            refugio = 1;
                            energia -= 20;
                        }
                        else
                        {
                            Console.WriteLine("Ya tienes un refugio");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Encendiste una fogata y recuperaste calor");
                        energia += 10;
                        comida -= 5;
                        break;

                    case 5:
                        Console.WriteLine("Descansaste un poco");
                        energia += 20;
                        comida -= 10;
                        break;

                    case 6:
                        Console.WriteLine("Saliste del juego");
                        break;

                    default:
                        Console.WriteLine("opcion invalida.");
                        break;
                }

                if (energia >= 100)
                {
                    Console.WriteLine("Sobreviviste y lograste adaptarte a la isla");
                    opcion = 6;
                }
            }

            if (energia <= 0 || comida <= 0)
            {
                Console.WriteLine("Perdiste. No lograste sobrevivir.");
            }

            Console.WriteLine("Fin del juego.");
        }
    }
}

