double lado1, lado2, lado3;


Console.WriteLine("Me diga o 1 lado do triângulo: ");
lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Me diga o 2 lado do triângulo: ");
lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Me diga o 3 lado do triângulo: ");
lado3 = double.Parse(Console.ReadLine());

if ((lado1 < (lado2 + lado3)) && (lado2 < (lado1 + lado3)) && (lado3 < (lado1 +lado2)))
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("É um triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3|| lado2 == lado3)
    {
        Console.WriteLine("É um triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("É um triângulo Escaleno");
    }
} else
{
    Console.WriteLine("Não forma um triângulo");
}