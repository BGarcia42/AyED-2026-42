using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int cruda = 0;
            int cocida = 0;
            int material = 0;
            bool refugio = false;
            bool fogata = false;
            int opcion = 1;
            bool texto = true;

            while (vida > 0 && opcion != 8)
            {
                if (texto == true)
                {
                    Console.WriteLine("Vida: " + vida);
                    Console.WriteLine("Hambre: " + hambre);
                    Console.WriteLine("Materiales: " + material);
                    Console.WriteLine("Comida cruda: " + cruda);
                    Console.WriteLine("Comida cocida: " + cocida);
                    if (refugio == true)
                    {
                        Console.WriteLine("Tenes refugio");
                    }
                    else
                    {
                        Console.WriteLine("No tenes refugio");
                    }
                    if (fogata == true)
                    {
                        Console.WriteLine("Tenes una fogata");
                    }
                    else
                    {
                        Console.WriteLine("No tenes una fogata");
                    }

                    Console.WriteLine("");

                    Console.WriteLine("Dia " + dia);

                    Console.WriteLine("");

                    Console.WriteLine("1. Buscar comida");
                    Console.WriteLine("2. Explorar la isla");
                    Console.WriteLine("3. Construir refugio (10 materiales)");
                    Console.WriteLine("4. Encender fogata (3 materiales)");
                    Console.WriteLine("5. Cocinar comida (requiere fogata encendida)");
                    Console.WriteLine("6. Comer comida cocida");
                    Console.WriteLine("7. Descansar");
                    Console.WriteLine("8. Salir del juego");
                }
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (char.IsDigit(input.KeyChar))
                {
                    opcion = int.Parse(input.KeyChar.ToString());
                }
                else
                {
                    opcion = 20;
                }
                texto = true;
                Console.WriteLine("");
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Random rand_comida = new Random();
                        int chance_comida = rand_comida.Next(0, 100);
                        if (chance_comida > 39)
                        {
                            Console.WriteLine("No encontraste comida.");
                        }
                        else
                        {
                            Console.WriteLine("¡Encontraste comida! +2 comida cruda, -1 vida.");
                            cruda += 2;
                            vida--;
                        }
                        dia++;
                        if (hambre < 1)
                        {
                            vida -= 2;
                        }
                        else
                        {
                            hambre -= 2;
                            if (hambre < 0)
                            {
                                hambre = 0;
                            }
                        }
                        break;
                    case 2:
                        Random rand_isla = new Random();
                        int chance_isla = rand_isla.Next(0, 100);
                        if (chance_isla > 49)
                        {
                            Console.WriteLine("¡Encontraste materiales! +3 materiales.");
                            material += 3;
                        }
                        else if (chance_isla < 31)
                        {
                            Console.WriteLine("No encontraste nada.");
                        }
                        else
                        {
                            Console.WriteLine("¡Estás herido! -2 vida.");
                            vida -= 2;
                        }
                        dia++;
                        if (hambre < 1)
                        {
                            vida -= 2;
                        }
                        else
                        {
                            hambre -= 2;
                            if (hambre < 0)
                            {
                                hambre = 0;
                            }
                        }
                        break;
                    case 3:
                        if (refugio == true)
                        {
                            Console.WriteLine("¡Ya tenes refugio! Elegí otra opción");
                            texto = false;
                        }
                        else if (material < 10)
                        {
                            Console.WriteLine("¡No tenes suficientes materiales! Elegí otra opción");
                            texto = false;
                        }
                        else
                        {
                            Console.WriteLine("Construiste un refugio.");
                            refugio = true;
                            material -= 10;
                            dia++;
                            if (hambre < 1)
                            {
                                vida -= 2;
                            }
                            else
                            {
                                hambre -= 2;
                                if (hambre < 0)
                                {
                                    hambre = 0;
                                }
                            }
                        }
                        break;
                    case 4:
                        if (fogata == true)
                        {
                            Console.Write("¡La fogata ya está encendida! Elegí otra opción");
                            texto = false;
                        }
                        else if (material < 3)
                        {
                            Console.WriteLine("¡No tenes suficientes materiales! Elegí otra opción");
                            texto = false;
                        }
                        else
                        {
                            Console.WriteLine("Encendiste la fogata.");
                            fogata = true;
                            material -= 3;
                            dia++;
                            if (hambre < 1)
                            {
                                vida -= 2;
                            }
                            else
                            {
                                hambre -= 2;
                                if (hambre < 0)
                                {
                                    hambre = 0;
                                }
                            }
                        }
                        break;
                    case 5:
                        if (fogata != true)
                        {
                            Console.WriteLine("¡No tenes una fogata encendida! Elegí otra opción");
                            texto = false;
                        }
                        else if (cruda < 1)
                        {
                            Console.WriteLine("¡No tenes comida para cocinar! Elegí otra opción");
                            texto = false;
                        }
                        else
                        {
                            Console.WriteLine("Cocinaste tu comida. +" + cruda + " comida cocida.");
                            cocida = cruda;
                            cruda = 0;
                            dia++;
                            if (hambre < 1)
                            {
                                vida -= 2;
                            }
                            else
                            {
                                hambre -= 2;
                                if (hambre < 0)
                                {
                                    hambre = 0;
                                }
                            }
                        }
                        break;
                    case 6:
                        if (cocida < 1)
                        {
                            Console.WriteLine("¡No tenés comida cocida! Elegí otra opción");
                            texto = false;
                        }
                        else
                        {
                            Console.WriteLine("¡Comiste 1 de comida cocida! +3 hambre.");
                            cocida--;
                            hambre += 3;
                            if (hambre > 10)
                            {
                                hambre = 10;
                            }
                            dia++;
                        }
                        break;
                    case 7:
                        if (refugio == true)
                        {
                            Console.WriteLine("Fuiste a dormir. +3 vida.");
                            vida += 3;
                            if (vida > 10)
                            {
                                vida = 10;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fuiste a dormir. +1 vida");
                            vida += 1;
                            if (vida > 10)
                            {
                                vida = 10;
                            }
                        }
                        dia++;
                        if (hambre < 1)
                        {
                            vida -= 2;
                        }
                        else
                        {
                            hambre -= 2;
                            if (hambre < 0)
                            {
                                hambre = 0;
                            }
                        }
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("¡No elegiste una opción válida! Intentá de nuevo.");
                        texto = false;
                        break;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Vida: " + vida);
            Console.WriteLine("Hambre: " + hambre);
            Console.WriteLine("Materiales: " + material);
            Console.WriteLine("Comida cruda: " + cruda);
            Console.WriteLine("Comida cocida: " + cocida);
            if (refugio == true)
            {
                Console.WriteLine("Tenes refugio");
            }
            else
            {
                Console.WriteLine("No tenes refugio");
            }
            if (fogata == true)
            {
                Console.WriteLine("Tenes una fogata");
            }
            else
            {
                Console.WriteLine("No tenes una fogata");
            }


            Console.WriteLine("");

            if (vida < 1)
            {
                Console.WriteLine("Moriste. Sobreviviste " + dia + " dias.");
            }
            else
            {
                Console.WriteLine("¡Gracias por jugar! Sobreviviste " + dia + " dias.");
            }
            Console.Write("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
