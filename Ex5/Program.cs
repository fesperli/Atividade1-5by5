int A, B;

Console.WriteLine("Digite o primeiro número: ");
A = int.Parse (Console.ReadLine ());
Console.WriteLine("Digite o segundo número: ");
B = int.Parse(Console.ReadLine());

if (A % B == 0)
{
    Console.WriteLine($"O numero {A} é multiplo de {B}");
}
else
{
    Console.WriteLine("Os numeros nao sao multiplos");
}