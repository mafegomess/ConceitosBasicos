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
            Console.WriteLine("Insira seu salário atual: ");
            float SalarioInicial = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o percentual de aumento? ");
            float Aumento = float.Parse(Console.ReadLine());
            Console.WriteLine($"Salário Inicial: {SalarioInicial};");
            Console.WriteLine($"Aumento: {Aumento}%;");
            float ValorAumento = SalarioInicial * (Aumento / 100);
            Console.WriteLine($"Valor do Aumento: {ValorAumento};");
            float NovoSalario = ValorAumento + SalarioInicial;
            Console.WriteLine($"Salário Atual: {NovoSalario};");
        }
    }
}
