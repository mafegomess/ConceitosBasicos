using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class MultiplosTresAteCem
    {
        public void TabuadaTresAteCem()
        {
            Console.WriteLine("\n- Múltiplos de Três de 0 a 100 -");
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
