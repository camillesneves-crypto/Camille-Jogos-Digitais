// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua vida");
int vida = int.Parse(Console.ReadLine());

{
    if (vida <= 0)
        Console.WriteLine("Game over.");
    else if (vida > 0)
        Console.WriteLine("Você ainda está vivo!");
}
