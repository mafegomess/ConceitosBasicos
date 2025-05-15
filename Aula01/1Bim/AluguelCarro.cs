using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class AluguelCarro
    {
        public void AlugarCarro()
        {
            try
            {
            Console.WriteLine("Insira o total de dias alugados: ");
            int DiasAlugados = int.Parse(Console.ReadLine());
                if (DiasAlugados == 0)
                {
                    throw new InputZeroException();
                }
                if (DiasAlugados < 0)
                {
                    throw new InputNegativoException();
                }
            Console.WriteLine("Insira a quilometragem inicial do carro: ");
            float KMInicial = float.Parse(Console.ReadLine());
                if (KMInicial < 0)
                {
                    throw new InputNegativoException();
                }
            Console.WriteLine("Insira a quilometragem final do carro: ");
            float KMFinal = float.Parse(Console.ReadLine());
                if (KMFinal < 0)
                {
                    throw new InputNegativoException();
                }
                if (KMFinal < KMInicial)
                {
                    throw new FinalMenorInicialException();
                }
            float KMTotal = KMFinal - KMInicial;
            float ValorAluguel = (float)(DiasAlugados * 95 + KMTotal * 0.35);
            Console.WriteLine($"O valor de aluguel a ser pago é: {ValorAluguel}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("O número de dias deve ser inteiro e as quilometragens devem ser números.");
            }
            catch (InputZeroException e)
            {
                Console.WriteLine("O valor de input não pode ser zero.");
            }
            catch (InputNegativoException e)
            {
                Console.WriteLine("O valor de input não pode ser negativo.");
            }
            catch(FinalMenorInicialException e)
            {
                Console.WriteLine("A quilometragem final não pode ser menor que a quilometragem inicial.");
            }
        }
    }
}
