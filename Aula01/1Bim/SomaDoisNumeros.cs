using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class SomaDoisNumeros
    {
        public void Somar()
        {
            Console.WriteLine("\nInsira o primeiro número que deseja somar: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número que deseja somar: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");

        }
    }

}
