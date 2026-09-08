using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");

            Console.ReadKey();
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            char[] buffer = s.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];

                if (c >= 'a' && c <= 'z')
                {
                    buffer[i] = (char)((c - 'a' + 1) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    buffer[i] = (char)((c - 'A' + 1) % 26 + 'A');
                }
            }

            string solution = new string(buffer);

            return solution;
        }
    }
}
