// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a vida atual:");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dano recebido:");
int dano = int.Parse(Console.ReadLine());

int vidaFinal = vida - dano;

if (vidaFinal > 0)
{
    Console.WriteLine("Vida final: " + vidaFinal);
}
else
{
    Console.WriteLine("Você foi derrotado.");
}
