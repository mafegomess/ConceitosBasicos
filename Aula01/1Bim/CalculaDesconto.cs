using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class CalculaDesconto
    {
        public void CalcularDesconto()
        {
            try
            {
            Console.WriteLine("Insira o valor da mercadoria: ");
            float ValorMercadoria = float.Parse(Console.ReadLine());
                if (ValorMercadoria == 0)
                {
                    throw new InputZeroException();
                }
                if (ValorMercadoria < 0)
                {
                    throw new InputNegativoException();
                }
            Console.WriteLine("Qual é o percentual de desconto? ");
            float Desconto = float.Parse(Console.ReadLine());
                if (Desconto == 0)
                {
                    throw new InputZeroException();
                }
                if (Desconto < 0)
                {
                    throw new InputNegativoException();
                }
            Console.WriteLine($"Valor Inicial da Mercadoria: {ValorMercadoria};");
            Console.WriteLine($"Desconto: {Desconto}%;");
            float ValorDesconto = ValorMercadoria * (Desconto / 100);
            Console.WriteLine($"Valor do Desconto: {ValorDesconto};");
            float NovoValorMercadoria = ValorMercadoria - ValorDesconto;
            Console.WriteLine($"Valor da Mercadoria com desconto: {NovoValorMercadoria};");
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
