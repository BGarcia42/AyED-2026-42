using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "pollitoconpapa123";
            Console.Write("Ingrese la contraseña: ");
            string usuario = Console.ReadLine().ToLower();
            if(contraseña == usuario)
            {
                Console.Write("¡La contraseña es correcta!");
            }
            else
            {
                Console.Write("La contraseña es incorrecta.");
            }
            Console.ReadKey();

        }
    }
}
