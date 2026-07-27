// See https://aka.ms/new-console-template for more information
Random sorteio = new Random();
int abrirPorta = sorteio.Next(1, 6);

while (abrirPorta != 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A porta continua fechada...");
    Console.ResetColor();

    Thread.Sleep(1500);

    abrirPorta = sorteio.Next(1, 6);
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("A porta se abriu!");
Console.ResetColor();

