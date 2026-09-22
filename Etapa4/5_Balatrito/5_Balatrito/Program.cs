using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Balatrito
{
    class Program
    {
        static void Main()
        {
            // Generar una mano aleatoria de 5 cartas
            string[] mano = GenerarManoAleatoria();
            // Analizar que tipo de mano se obtuvo
            string tipo = TipoDeMano(mano);
            // Calcular el valor de las cartas
            int basePts = PuntajeBase(mano);
            // Obtener el multiplicador de la jugada
            double mult = Multiplicador(tipo);
            // Calcular puntaje antes de Jokers
            double total = basePts * mult;
            // Jokers disponibles
            bool jokerX2 = true;
            bool jokerMas10 = true;
            // Aplicar los efectos de los Jokers
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // Mostrar el resultado
            MostrarResumen(mano, tipo, basePts, mult, total);

            Console.ReadKey();
        }

        static string[] GenerarManoAleatoria()
        {
            string[] cartas = new string[5];
            string numPosible = "AKQJT98765432";
            string paloPosible = "HDCS";
            Random random = new Random();

            for (int i = 0; i < cartas.Length; i++)
            {
                int randNum = random.Next(numPosible.Length);
                int randPalo = random.Next(paloPosible.Length);
                char numero = numPosible[randNum];
                char palo = paloPosible[randPalo];

                StringBuilder sb = new StringBuilder();
                sb.Append(numero);
                sb.Append(palo);
                string carta = sb.ToString();
                cartas[i] = carta;
            }
            return cartas;
        }

        static string TipoDeMano(string[] mano)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mano.Length; i++)
            {
                string tmp = mano[i];
                sb.Append(tmp[0]);
            }
            string nums = sb.ToString();
            char frequente = nums
                .GroupBy(c => c)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
            char otro = nums
                .GroupBy(c => c)
                .OrderByDescending(g => g.Count())
                .Last()
                .Key;
            int cantidad = nums.Count(c => c == frequente);
            int cant2 = nums.Count(c => c == otro);
            switch (cantidad)
            {
                case 2:
                    return "Par";

                case 3:
                    if (cant2 == 2) { return "Full"; }
                    else { return "Trio"; }

                case 4:
                    return "Poker";

                default:
                    return "Nada";
            }
        }

        static int PuntajeBase(string[] mano)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mano.Length; i++)
            {
                string tmp = mano[i];
                sb.Append(tmp[0]);
            }
            string cartas = sb.ToString();

            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                if (char.IsDigit(cartas[i])) { nums[i] = cartas[i] - '0'; }
                else if (cartas[i] == 'A') { nums[i] = 14; }
                else if (cartas[i] == 'K') { nums[i] = 13; }
                else if (cartas[i] == 'Q') { nums[i] = 12; }
                else if (cartas[i] == 'J') { nums[i] = 11; }
                else { nums[i] = 10; }
            }

            int suma = 0;
            for (int i = 0; i < nums.Length; i++) { suma += nums[i]; }
            return suma;
        }

        static double Multiplicador(string tipo)
        {
            if (tipo == "Par") { return 1.5; }
            else if (tipo == "Trio") { return 2.5; }
            else if (tipo == "Full") { return 3.5; }
            else if (tipo == "Poker") { return 4; }
            else { return 1; }
        }

        static double AplicarJokers(double total, bool jx2, bool j10)
        {
            double totalj = total;
            if (jx2) { totalj *= 2; }
            if (j10) { totalj += 10; }
            return totalj;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Mano:");
            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write(" [" + mano[i] + "]");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Tipo de mano: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: " + mult);
            Console.WriteLine("Total (con jokers): " + total);
        }
    }
}
