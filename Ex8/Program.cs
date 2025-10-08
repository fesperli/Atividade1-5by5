float nota1, nota2, nota3;
int peso1, peso2, peso3;

Console.WriteLine("Digite a nota 1: ");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da nota 1: ");
peso1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 2: ");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da nota 2: ");
peso2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 3: ");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da nota 3: ");
peso3 = int.Parse(Console.ReadLine());

float media;

media = (nota1 * peso2) + (nota2 * peso2) + (nota3 * peso3) / (peso1 + peso2 + peso3);

Console.WriteLine($"media : {media}");

if (media >= 9)
{
    Console.WriteLine("Nota A");
} 
    if (media >= 7 && media < 9){
    Console.WriteLine("Nota B");
}
        if (media >= 5 && media < 7)
{
    Console.WriteLine("Nota C");
}
            if (media < 5)
{
    Console.WriteLine("Nota D");
}