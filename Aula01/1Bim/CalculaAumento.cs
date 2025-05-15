using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class CalculaAumento
    {
        public void CalcularAumento()
        {
            try
            {
            Console.WriteLine("Insira seu salário atual: ");
            float SalarioInicial = float.Parse(Console.ReadLine());
                if (SalarioInicial == 0)
                {
                    throw new InputZeroException();
                }
                if (SalarioInicial < 0)
                {
                    throw new InputNegativoException();
                }
                Console.WriteLine("Qual é o percentual de aumento? ");
            float Aumento = float.Parse(Console.ReadLine());
                if (Aumento == 0)
                {
                    throw new InputZeroException();
                }
                if (Aumento < 0)
                {
                    throw new InputNegativoException();
                }
                Console.WriteLine($"Salário Inicial: {SalarioInicial};");
            Console.WriteLine($"Aumento: {Aumento}%;");
            float ValorAumento = SalarioInicial * (Aumento / 100);
            Console.WriteLine($"Valor do Aumento: {ValorAumento};");
            float NovoSalario = ValorAumento + SalarioInicial;
            Console.WriteLine($"Salário Atual: {NovoSalario};");
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
        }
    }
}
