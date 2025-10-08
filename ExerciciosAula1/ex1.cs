float nota1, nota2, nota3;

Console.WriteLine("Digite a primeira nota: ");
nota1 = float.Parse (Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
nota2 = float.Parse (Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
nota3 =float.Parse (Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("A media das notas é: " + media);