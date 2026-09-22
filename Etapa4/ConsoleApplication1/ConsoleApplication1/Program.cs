using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Producto
    {
        string nombre;
        int ID = 1234;
        public int precio  = 1000;
        int stock = 1000;
        string lista_productos;
    }

    class Carrito
    {
    List<Producto> lista_productos = new List<Producto>();

    public int Calcular_total()
     {
       int total = 0;

    foreach (Producto producto in lista_productos)
        {
         total += producto.precio;
        } return total;
      }
    }

    class Program
        {
            static void Main()
            {
                List<Producto> lista_productos = new List<Producto>();

            Producto producto1 = new Producto();
            Carrito carrito1 = new Carrito();
            Console.ReadKey();
           

            }

        }
        }








