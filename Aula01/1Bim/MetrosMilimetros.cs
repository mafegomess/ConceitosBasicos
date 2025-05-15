using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class MetrosMilimetros
    {
        public void Transformar()
        {
            try
            {
            Console.WriteLine("\nInsira o valor em Metros: ");
            float ValorM = float.Parse(Console.ReadLine());
                if (ValorM < 0)
                {
                    throw new InputNegativoException();
                }
            float ValorMili = ValorM * 1000;
            Console.WriteLine($"{ValorM} metros é igual a {ValorMili} milímetros.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não foi digitado um número.");
            }
            catch (InputNegativoException e)
            {
                Console.WriteLine("O valor de input não pode ser negativo.");
            }
        }
    }
}
