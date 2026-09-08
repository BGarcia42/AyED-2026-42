using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
            bool ok = Level1.ValidateAccessKey("WD-700000")
                      && !Level1.ValidateAccessKey("WD-123123")
                      && !Level1.ValidateAccessKey("WX-000007")
                      && !Level1.ValidateAccessKey("WD-00007");
            if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
            else Console.WriteLine("🔒 LOCKED");

            Console.ReadKey();
        }
    }

    static class Level1
    {
        // Debe devolver true solo si:
        // - Empieza por "WD-"
        // - Luego hay exactamente 6 dígitos
        // - La suma de esos 6 dígitos es múltiplo de 7
        public static bool ValidateAccessKey(string key)
        {
            bool status = false;

            if (key.StartsWith("WD-") == true)
            {
                if (key.Length == 9)
                {
                    int i = 3;
                    bool esNumero = true;
                    while (i < 9 && esNumero == true)
                    {
                        esNumero = char.IsDigit(key[i]);
                        i++;
                    }
                    if (esNumero == true)
                    {
                        int suma = (key[3] - '0') + (key[4] - '0') + (key[5] - '0') + (key[6] - '0') + (key[7] - '0') + (key[8] - '0');
                        bool multiplo = false;
                        if (suma % 7 == 0) { multiplo = true; }
                        if (multiplo == true) { status = true; }
                    }
                }
            }

            return status;
        }
    }
}
