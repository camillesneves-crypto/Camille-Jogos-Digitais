// See https://aka.ms/new-console-template for more information
Random sorteio = new Random();
int itemRaro = (sorteio.Next(1, 11));
int tentativas = 0;

while (itemRaro != 10)
{
    itemRaro = sorteio.Next(1, 11);
    tentativas++;

    if (itemRaro != 10)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você não encontrou o item raro.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Você encontrou o item raro!");
Console.ResetColor();

Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Tentativas: " + tentativas);
Console.ResetColor();