using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class CalcularAposentadoria
    {
        public void CalculoDeAposentadoria()
        {
            try
            {
                Console.Write("Informe sua idade atual: ");
                int idadeAtual = int.Parse(Console.ReadLine());
                if (idadeAtual == 0)
                {
                    throw new InputZeroException();
                }
                if (idadeAtual < 0)
                {
                    throw new InputNegativoException();
                }
                Console.Write("Com quantos anos pretende se aposentar? ");
                int idadeAposentadoria = int.Parse(Console.ReadLine());
                if (idadeAposentadoria == 0)
                {
                    throw new InputZeroException();
                }
                if (idadeAposentadoria < 0)
                {
                    throw new InputNegativoException();
                }
                if (idadeAposentadoria < idadeAtual)
                {
                    throw new FinalMenorInicialException();
                }
                Console.Write("Informe o valor que pretende guardar mensalmente para aposentadoria: ");
                float valorMensal = float.Parse(Console.ReadLine());
                if (valorMensal == 0)
                {
                    throw new InputZeroException();
                }
                if (valorMensal < 0)
                {
                    throw new InputNegativoException();
                }
                Console.Write("Informe a taxa de rendimento mensal da aplicação (em %): ");
                float taxaRendimento = float.Parse(Console.ReadLine()) / 100;
                if (taxaRendimento == 0)
                {
                    throw new InputZeroException();
                }
                if (taxaRendimento < 0)
                {
                    throw new InputNegativoException();
                }

                int meses = (idadeAposentadoria - idadeAtual) * 12;

                float montante = 0;
                for (int i = 0; i < meses; i++)
                {
                    valorMensal += valorMensal * taxaRendimento;
                    montante += valorMensal;
                }

                float rendaMensal = montante * taxaRendimento;

                Console.WriteLine($"\nMontante acumulado no período: R$ {montante:F2}");
                Console.WriteLine($"Renda mensal possível mantendo o valor na aplicação: R$ {rendaMensal:F2}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não foi digitado um número.");
            }
            catch (InputZeroException e)
            {
                Console.WriteLine("O valor de input não pode ser zero.");
            }
            catch (InputNegativoException e)
            {
                Console.WriteLine("O valor de input não pode ser negativo.");
            }
            catch (FinalMenorInicialException e)
            {
                Console.WriteLine("A idade de aposentadoria não pode ser menor que a atual.");
            }
        }
    }
}

