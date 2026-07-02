// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vida do inimigo:");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Energia do jogador:");
int energia = int.Parse(Console.ReadLine());

Console.WriteLine("Dano do ataque:");
int dano = int.Parse(Console.ReadLine());

if (energia >= 10)
{
    vida = vida - dano;

    if (vida <= 0)
    {
        Console.WriteLine("Inimigo derrotado");
    }
    else
    {
        Console.WriteLine(vida);
    }
}
else
{
    Console.WriteLine("Energia insuficiente");
}