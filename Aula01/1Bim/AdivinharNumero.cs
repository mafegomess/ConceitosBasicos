using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class AdivinharNumero
    {
        public void AdivinharNumeroAleatorio()
        {
            Random random = new Random();
            int NumAleatorio = random.Next(0, 100);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Adivinhe um número de 0 a 100 (Chance {i+1}): ");
                    int Chute = int.Parse(Console.ReadLine());
                    if (Chute < 0 || Chute > 100)
                    {
                        throw new IntervaloInvalidoException();
                    }
                    if (Chute == NumAleatorio)
                    {
                        Console.WriteLine("Você Acertou!!!");
                        break;
                    }
                    else
                    {
                        if(NumAleatorio < Chute)
                        {
                            Console.WriteLine("\nVocê errou. O número é menor. Tente Novamente.");
                        }
                        else
                        {
                            Console.WriteLine("\nVocê errou. O número é maior. Tente Novamente.");
                        }
                    }
                }
                Console.WriteLine($"O número era {NumAleatorio}");
                Console.WriteLine("Fim da adivinhação.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não foi digitado um número inteiro.");
            }
            catch (IntervaloInvalidoException e)
            {
                Console.WriteLine("O número digitado não está inserido no intervalo permitido.");
            }
        }
    }
}
