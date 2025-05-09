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
            Console.WriteLine("Insira o total de dias alugados: ");
            int DiasAlugados = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quilometragem inicial do carro: ");
            float KMInicial = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quilometragem final do carro: ");
            float KMFinal = float.Parse(Console.ReadLine());
            float KMTotal = KMFinal - KMInicial;
            float ValorAluguel = (float)(DiasAlugados * 95 + KMTotal * 0.35);
            Console.WriteLine($"O de alguel a ser pago é: {ValorAluguel}");
        }
    }
}
