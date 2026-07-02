// See https://aka.ms/new-console-template for more information
int vida;
int energia;
int nivel;

Console.Write("Vida: ");
vida = int.Parse(Console.ReadLine());

Console.Write("Energia: ");
energia = int.Parse(Console.ReadLine());

Console.Write("Nível: ");
nivel = int.Parse(Console.ReadLine());

if (vida > 50 && energia >= 30 && nivel >= 3)
{
    Console.WriteLine("Você entrou na dungeon.");
}
else
{
    Console.WriteLine("Você ainda não está preparado.");
}
