using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class ImpostoDeRenda
    {
        public void CalcularIRPF()
        {
            try
            {
                Console.WriteLine("Informe sua renda mensal: ");
                float Renda = float.Parse(Console.ReadLine());
                if (Renda < 0)
                {
                    throw new InputNegativoException();
                }
                Console.WriteLine("Quantos dependentes você possui? ");
                int Dependentes = int.Parse(Console.ReadLine());
                if (Dependentes < 0)
                {
                    throw new InputNegativoException();
                }
                if (Renda <= 1903.98)
                {
                    Console.WriteLine("Aliquota: 0 - Parcela a deduzir: R$0");
                    Console.WriteLine($"Dedução anual: R${0 * 12}");
                }
                else if (1903.99 <= Renda && Renda <= 2826.65)
                {
                    Console.WriteLine("Aliquota: 7,5% - Parcela a deduzir: R$142,80");
                    Console.WriteLine($"Dedução anual: R${142.80 * 12}");
                }
                else if (2826.66 <= Renda && Renda <= 3751.05)
                {
                    Console.WriteLine("Aliquota: 15% - Parcela a deduzir: R$354,80");
                    Console.WriteLine($"Dedução anual: R${354.80 * 12}");
                }
                else if (3751.06 <= Renda && Renda <= 4664.68)
                {
                    Console.WriteLine("Aliquota: 22,5% - Parcela a deduzir: R$636,13");
                    Console.WriteLine($"Dedução anual: R${636.13 * 12}");
                }
                else if (Renda > 4664.68)
                {
                    Console.WriteLine("Aliquota: 27,5% - Parcela a deduzir: R$869,36");
                    Console.WriteLine($"Dedução anual: R${869.36 * 12}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não foi digitado um número válido.");
            }
            catch (InputNegativoException e)
            {
                Console.WriteLine("O valor de input não pode ser negativo.");
            }
        }
    }
}
