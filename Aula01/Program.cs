// See https://aka.ms/new-console-template for more information

using Aula01._1Bim;

int num1 = 20;
int num2 = 22;
SomaDoisNumeros somador = new SomaDoisNumeros();
int resultado = somador.Somar(num1, num2);
Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");

float ValorM = 10;
MetrosMilimetros transformador = new MetrosMilimetros();
float ValorMili = transformador.Transformar(ValorM);
Console.WriteLine($"{ValorM} metros é igual a {ValorMili} milímetros.");

//CalculaAumento calcular = new CalculaAumento();
//calcular.CalcularAumento();

//CalculaDesconto descontar = new CalculaDesconto();
//descontar.CalcularDesconto();

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
