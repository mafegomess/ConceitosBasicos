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
            Console.WriteLine("Insira o valor da mercadoria: ");
            float ValorMercadoria = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o percentual de desconto? ");
            float Desconto = float.Parse(Console.ReadLine());
            Console.WriteLine($"Valor Inicial da Mercadoria: {ValorMercadoria};");
            Console.WriteLine($"Desconto: {Desconto}%;");
            float ValorDesconto = ValorMercadoria * (Desconto / 100);
            Console.WriteLine($"Valor do Desconto: {ValorDesconto};");
            float NovoValorMercadoria = ValorMercadoria - ValorDesconto;
            Console.WriteLine($"Valor da Mercadoria com desconto: {NovoValorMercadoria};");
        }
    }
}
