using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int vidas = 5;
            Console.Write("Ingrese la opcion que necesite 1- Buscar comida 2- Explorar la isla 3- Construir refugio 4- Encender fogata 5- Descansar  ");
            int opciones = int.Parse(Console.ReadLine());


            switch (opciones)
            {
                case 1:
                    string contaminado = Console.ReadLine();
                    Console.WriteLine("buscar comida");
                    string[] comida = { "carne", "pollo", "fideos", "arroz "+  contaminado};


                    if (comida == contaminado)
                        vidas--;   
                        break;
                    

                case 2:
                    
                        Console.WriteLine("explorar la isla");
                        string[] nombres = { "ariana", "sheila", "tomas", "candela", "coral" };
                     
                        break;
                    

                case 3:
                    
                        Console.WriteLine("construir refugio");
                        string[] mejoras = { "ropa", "suministros", "diamantes", "vidas" };
                     
                        break;
                    

                case 4:
                    
                        Console.WriteLine("salir");
                        return;
                    
            }

            Console.ReadKey();
        }
    }
}

