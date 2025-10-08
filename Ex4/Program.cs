float peso, altura;

Console.WriteLine("Digite seu peso: ");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);

if (imc < 18.5) {
    Console.WriteLine("Você está abaixo do peso!!");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("Seu peso está normal!!");
}
else if (imc >= 25 && imc <= 29.9)
    {
    Console.WriteLine("Você está com sobrepeso!!");
}
else if (imc >= 30)
{
    Console.WriteLine("Você está com obesidade!!");
}

