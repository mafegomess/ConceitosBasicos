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
            try
            {
                Console.WriteLine("Insira seu peso (Em KG): ");
                float Peso = float.Parse(Console.ReadLine());
                if (Peso == 0)
                {
                    throw new InputZeroException();
                }
                if (Peso < 0)
                {
                    throw new InputNegativoException();
                }
                Console.WriteLine("Insira sua altura (Em Metros): ");
                float Altura = float.Parse(Console.ReadLine());
                if (Altura == 0)
                {
                    throw new InputZeroException();
                }
                if (Altura < 0)
                {
                    throw new InputNegativoException();
                }
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
            catch (FormatException e)
            {
                Console.WriteLine("Tipo de dado incompatível.");
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
