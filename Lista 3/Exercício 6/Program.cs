// See https://aka.ms/new-console-template for more information
Random sorteio = new Random();
int cristal = sorteio.Next(1, 4);
int quantidadeCristais = 0;

while (quantidadeCristais < 5)
{
    cristal = sorteio.Next(1, 4);

    if (cristal == 1)
    {
        quantidadeCristais++;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Você encontrou um cristal!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Quantidade de cristais: " + quantidadeCristais);
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (cristal == 2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Você não encontrou nada.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Quantidade de cristais: " + quantidadeCristais);
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (cristal == 3)
    {
        if (quantidadeCristais > 0)
        {
            quantidadeCristais--;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você perdeu um cristal!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Quantidade de cristais: " + quantidadeCristais);
        Console.ResetColor();
        Thread.Sleep(1500);
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Parabéns! Você coletou 5 cristais!");
Console.ResetColor();

