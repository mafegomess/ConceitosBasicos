// See https://aka.ms/new-console-template for more information

using Aula01._1Bim;

SomaDoisNumeros Soma = new SomaDoisNumeros();
MetrosMilimetros Conversor = new MetrosMilimetros();

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n0 - Sair");
    Console.WriteLine("1 - Somar dois numeros");
    Console.WriteLine("2 - Converter metros para milímetros");
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
        case 0:
            continuar = false;
            break;
        default:
            Console.WriteLine("opção inválida");
            break;
    }
}




CalculaAumento calcular = new CalculaAumento();
calcular.CalcularAumento();

CalculaDesconto descontar = new CalculaDesconto();
descontar.CalcularDesconto();

AluguelCarro alugar = new AluguelCarro();
alugar.AlugarCarro();

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
