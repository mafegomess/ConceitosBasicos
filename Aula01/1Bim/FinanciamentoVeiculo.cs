using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class FinanciamentoVeiculo
    {
        public void CalcularFinanciamentoVeiculo()
        {
            try
            {
                Console.WriteLine("Informe o valor do veículo: ");
                float ValorVeiculo = float.Parse(Console.ReadLine());
                if (ValorVeiculo == 0)
                {
                    throw new InputZeroException();
                }
                if (ValorVeiculo < 0)
                {
                    throw new InputNegativoException();
                }
                Console.WriteLine("Informe o total de parcelas: ");
                int Parcelas = int.Parse(Console.ReadLine());
                if (Parcelas == 0)
                {
                    throw new InputZeroException();
                }
                if (Parcelas < 0)
                {
                    throw new InputNegativoException();
                }
                Console.WriteLine("Informe o valor da taxa mensal (%): ");
                float Taxa = float.Parse(Console.ReadLine());
                if (Taxa < 0)
                {
                    throw new InputNegativoException();
                }
                float ValorTotal = 0;
                if (Taxa == 0)
                {
                    Taxa = 3; //Taxa administrativa
                    ValorTotal = (ValorVeiculo + (ValorVeiculo * (Taxa / 100)));
                    float ValorEntrada = (float)(ValorVeiculo * 0.6);
                    Console.WriteLine($"Deve ser dado R${ValorEntrada} de entrada");
                    Console.WriteLine($"O valor da parcela é: R${(ValorVeiculo - ValorEntrada)/Parcelas:F2}");
                }
                else
                {
                    ValorTotal = (float)(ValorVeiculo * (Math.Pow((1 + Taxa / 100), Parcelas)));
                    Console.WriteLine($"O valor da parcela é: R${ValorTotal/Parcelas}");

                }
                Console.WriteLine($"O valor total a ser pago pelo veículo é de: {ValorTotal:F2}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Esse tipo de input não é válido.");
            }
            catch (InputZeroException e)
            {
                Console.WriteLine("O valor de input não pode ser zero.");
            }
            catch (InputNegativoException e)
            {
                Console.WriteLine("O valor de input não pode ser negativo.");
            }
        }
    }
}
