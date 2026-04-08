using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comida = false;
            bool refugio = false;
            bool bate = false;
            Console.WriteLine("Responde con SI o NO para saber si sobrevivis al apocalípsis.");
            Console.Write("¿Tenés comida? ");
            string res1 = Console.ReadLine();
            res1 = res1.Replace(" ", "");
            Console.Write("¿Tenés refugio? ");
            string res2 = Console.ReadLine();
            res2 = res2.Replace(" ", "");
            Console.Write("¿Tenés un bate? ");
            string res3 = Console.ReadLine();
            res3 = res3.Replace(" ", "");
            if (res1.ToLower() == "si")
            {
                comida = true;
            }
            if (res2.ToLower() == "si")
            {
                refugio = true;
            }
            if (res3.ToLower() == "si")
            {
                bate = true;
            }
            if (comida == true && refugio == true && bate == true)
            {
                Console.WriteLine("Sobrevivis sin problema.");
            }
            if (comida == false && refugio == true)
            {
                Console.WriteLine("Sobrevivis por un rato pero despues te moris de hambre.");
            }
            if (comida == true && refugio == true && bate == false)
            {
                Console.WriteLine("Podes sobrevivir pero no salgas y protegete muy bien.");
            }
            if (refugio == false)
            {
                Console.WriteLine("Te moris por que no tenés donde protegerte.");
            }
            Console.ReadKey();
        }
    }
}
