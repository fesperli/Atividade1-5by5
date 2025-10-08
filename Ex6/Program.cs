using System.Diagnostics;

double Valor;
double Desconto = 0.10;
int escolha;
Console.WriteLine("Qual o valor do produto desejado?");
Valor = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a forma de pagamento: ");
Console.WriteLine("1: A vista (10% de desconto) ");
Console.WriteLine("2: Parcelado");
escolha = int.Parse(Console.ReadLine());
switch (escolha)
{
    case 1:
        double ValorFinal;
            ValorFinal = Valor - (Valor * Desconto);
        Console.WriteLine("Você escolheu pagar a vista");
        Console.WriteLine($"O valor final é: {ValorFinal}");
        break;

default: 
   { Console.WriteLine("Você escolheu pagar parcelado");
    Console.WriteLine("O valor final é: " + Valor);
    break;
}
}
//tive dificuldade em realizar a entrada de dados para utilizar o switch e selecionar a opção