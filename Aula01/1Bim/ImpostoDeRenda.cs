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
                float Deducao = 0;
                float ImpostoTotal = 0;
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
                }
                else if (1903.99 <= Renda && Renda <= 2826.65)
                {
                    Deducao = (float)(Dependentes * 142.80);
                    Console.WriteLine($"Aliquota: 7,5% - Parcela a deduzir: R${Deducao:F2}");
                    ImpostoTotal = (float)((Renda - Deducao) * 0.075);
                }
                else if (2826.66 <= Renda && Renda <= 3751.05)
                {
                    Deducao = (float)(Dependentes * 354.80);
                    Console.WriteLine($"Aliquota: 15% - Parcela a deduzir: R${Deducao:F2}");
                    ImpostoTotal = (float)((Renda - Deducao) * 0.15);
                }
                else if (3751.06 <= Renda && Renda <= 4664.68)
                {
                    Deducao = (float)(Dependentes * 636.13);
                    Console.WriteLine($"Aliquota: 22,5% - Parcela a deduzir: R${Deducao:F2}");
                    ImpostoTotal = (float)((Renda - Deducao) * 0.225);
                }
                else if (Renda > 4664.68)
                {
                    Deducao = (float)(Dependentes * 869.36);
                    Console.WriteLine($"Aliquota: 27,5% - Parcela a deduzir: R${Deducao:F2}");
                    ImpostoTotal = (float)((Renda - Deducao) * 0.275);
                }
                Console.WriteLine($"Imposto mensal a pagar: R${ImpostoTotal:F2}");
                Console.WriteLine($"Salário líquido: R${Renda - ImpostoTotal:F2}");
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
