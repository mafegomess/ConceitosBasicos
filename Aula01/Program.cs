// See https://aka.ms/new-console-template for more information

using Aula01._1Bim;

SomaDoisNumeros Soma = new SomaDoisNumeros();
MetrosMilimetros Conversor = new MetrosMilimetros();
CalculaAumento Aumento = new CalculaAumento();
CalculaDesconto Descontar = new CalculaDesconto();
AluguelCarro Alugar = new AluguelCarro();
IMC CalculoIMC = new IMC();
//Tabuada Multiplica = new Tabuada();
//MultiplosTresAteCem TresMultiplo = new MultiplosTresAteCem();
//FatorialUmADez Fatorial = new FatorialUmADez();
//ImpostoDeRenda Imposto = new ImpostoDeRenda();
//AdivinharNumero Adivinhar = new AdivinharNumero();
//FinanciamentoVeiculo Financiamento = new FinanciamentoVeiculo();
//CalcularAposentadoria Aposentadoria = new CalcularAposentadoria();

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n--- Menu de Opções ---");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar dois numeros");
    Console.WriteLine("2 - Converter metros para milímetros");
    Console.WriteLine("3 - Calcular aumento de salário");
    Console.WriteLine("4 - Calcular desconto de produto");
    Console.WriteLine("5 - Calcular valor de alguel da carro");
    Console.WriteLine("6 - Calcular IMC");
    Console.WriteLine("7 - Tabuada de um número x");
    Console.WriteLine("8 - Múltiplos de 3 entre 0 e 100");
    Console.WriteLine("9 - Fatoriais de 1 até 10");
    Console.WriteLine("10 - Calcular imposto de renda");
    Console.WriteLine("11 - Adivinhar número");
    Console.WriteLine("12 - Financiamento de veículo");
    Console.WriteLine("13 - Cálculo de aposentadoria");
    Console.WriteLine("Informe a opção desejada: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Soma.Somar();
            break;
        case 2:
            Conversor.Transformar();
            break;
        case 3:
            Aumento.CalcularAumento();
            break;
        case 4:
            Descontar.CalcularDesconto();
            break;
        case 5:
            Alugar.AlugarCarro();
            break;
        case 6:
            CalculoIMC.CalcularIMC();
            break;
        case 7:
            //Multiplica.CalcularTabuada();
            break;
        case 8:
            //TresMultiplo.TabuadaTresAteCem();
            break;
        case 9:
            //Fatorial.CalcularFatorial();
            break;
        case 10:
            //Imposto.CalcularIRPF();
            break;
        case 11:
            //Adivinhar.AdivinharNumeroAleatorio();
            break;
        case 12:
            //Financiamento.CalcularFinanciamentoVeiculo();
            break;
        case 13:
            //Aposentadoria.CalculoDeAposentadoria();
            break;
        case 0:
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if (idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine($"Seja bem-vinda {nome}! Você tem {idade} anos.");
    if(idade % 2 == 0)
    {
        Console.WriteLine("Sua idade é um número par.");
    }
    else
    {
        Console.WriteLine("Sua idade é um número impar.");
    }
    string primo = "";
    for(int i = 2; i <= idade/2; i++)
    {
        if(idade % i == 0)
        {
            primo = "não";
            break;
        }
    
    }
    Console.WriteLine($"A idade {primo} é um número primo.");
}
    
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro.");
}
catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se 1 é primo ou não.");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
