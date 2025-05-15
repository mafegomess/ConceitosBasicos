using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class FatorialUmADez
    {
        public void CalcularFatorial()
        {
            Console.WriteLine("\n- Fatoriais de 1 a 10 -");
            for (int i = 1; i <= 10; i++)
            {
                int fatorial = 1;
                for(int j = 1; j <= i; j++)
                {
                    fatorial = fatorial * j;
                }
                Console.WriteLine($"{i}! = {fatorial}");
            }
        }
    }
}
