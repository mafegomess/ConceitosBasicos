using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class Tabuada
    {
        public void CalcularTabuada()
        {
            try
            {
                Console.WriteLine("\nInsira o número que deseja saber a tabuada: ");
                int num = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {i * num}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não foi digitado um número inteiro.");
            }

        }
    }
}
