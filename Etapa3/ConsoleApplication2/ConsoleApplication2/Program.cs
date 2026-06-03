using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            {
                double compra;
                double pago;
                double vuelto;

                Console.Write("Ingrese el monto de la compra: ");
                compra = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el dinero entregado: ");
                pago = Convert.ToDouble(Console.ReadLine());

                if (pago < compra)
                {
                    Console.WriteLine("Error: el dinero entregado es insuficiente");
                }
                else
                {
                    vuelto = pago - compra;

                    Console.WriteLine("Vuelto total: $" + vuelto);

                    int restante = (int)vuelto;

                    int[] billetes = { 10000, 2000, 1000, 500, 200, 100, 50, 20, 10 };

                    for (int i = 0; i < billetes.Length; i++)
                    {
                        int cantidad = restante / billetes[i];

                        if (cantidad > 0)
                        {
                            Console.WriteLine(cantidad + " billete de $" + billetes[i]);
                        }

                        restante = restante % billetes[i];
                    }

                    double resto = vuelto - (int)vuelto + restante;

                    if (resto > 0)
                    {
                        Console.WriteLine("Resto menor a $10: $" + resto);
                    }
                }

                Console.WriteLine("Fin del programa");
            }
        }

    }

}
