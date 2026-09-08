using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
            bool ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");

            Console.ReadKey();
        }
    }

    static class Level3
    {
        public static int CountAdjacent(int[,] grid, int row, int col)
        {
            int cantidad = 0;
            int tmp_row = 0;
            int tmp_col = 0;

            if (row > 0) { tmp_row = 1; }
            if (col > 0) { tmp_col = 1; }

            if (grid[row - tmp_row, col] == 1) { cantidad += 1; }
            if (grid[row + 1, col] == 1) { cantidad += 1; }
            if (grid[row, col - tmp_col] == 1) { cantidad += 1; }
            if (grid[row, col + 1] == 1) { cantidad += 1; }

            return cantidad;
        }
    }
}
