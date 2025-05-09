using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class IMC
    {
        public void CalcularIMC()
        {
            Console.WriteLine("Insira seu peso (Em KG): ");
            float Peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura (Em Metros): ");
            float Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu gênero: ");
            string Genero = Console.ReadLine();
            float ValorIMC = Peso / (Altura * Altura);
            Console.WriteLine($"Seu IMC é de {ValorIMC}");
            if (ValorIMC < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (ValorIMC >= 18.5 && ValorIMC < 25)
            {
                Console.WriteLine("Você está com o peso ideal.");
            }
            else if (ValorIMC >= 25 && ValorIMC < 30)
            {
                Console.WriteLine("Você está levemente acima do peso.");
            }
            else if (ValorIMC >= 30 && ValorIMC < 35)
            {
                Console.WriteLine("Você está com obesidade grau I.");
            }
            else if (ValorIMC >= 35 && ValorIMC < 30)
            {
                Console.WriteLine("Você está com obesidade grau II (severa).");
            }
            else
            {
                Console.WriteLine("Você está com obesidade grau III (mórbida).");
            }
        }
    }
}
