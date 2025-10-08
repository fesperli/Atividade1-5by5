int nmr;

Console.WriteLine("Digite um número inteiro: ");
nmr = int.Parse(Console.ReadLine());

if (nmr % 2 == 0)
{
    Console.WriteLine("O número é par!!");
}
else
{
    Console.WriteLine("o número é ímpar!!");
}