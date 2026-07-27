// See https://aka.ms/new-console-template for more information
Random sorteio = new Random();
int dado = sorteio.Next(1, 7);

while (dado != 6)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("O dado caiu em: " + dado);
    Console.ResetColor();

    Thread.Sleep(1500);

    dado = sorteio.Next(1, 7);
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Você tirou 6! Fim da rolagem.");
Console.ResetColor();
