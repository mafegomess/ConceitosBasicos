using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1Bim
{
    internal class MetrosMilimetros
    {
        public void Transformar()
        {
            Console.WriteLine("\nInsira o valor em Metros: ");
            float ValorM = float.Parse(Console.ReadLine());
            float ValorMili = ValorM * 1000;
            Console.WriteLine($"{ValorM} metros é igual a {ValorMili} milímetros.");
        }
    }
}
