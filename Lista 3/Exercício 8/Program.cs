// See https://aka.ms/new-console-template for more information
int escolha; 
Random sorteio = new Random();
int evento = sorteio.Next(1, 5);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("O que você deseja fazer?");
Console.WriteLine("1 - Explorar");
Console.WriteLine("2 - Sair");
Console.ResetColor();

escolha = int.Parse(Console.ReadLine());

while (escolha != 2)
{
    evento = sorteio.Next(1, 5);

    if (evento == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Você encontrou moedas.");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (evento == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Você encontrou uma pista.");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (evento == 3)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você encontrou um obstáculo");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (evento == 4)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Nada aconteceu.");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Sair");
    Console.ResetColor();

    escolha = int.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Você saiu do jogo.");
Console.ResetColor();