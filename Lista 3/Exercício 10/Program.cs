// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int vida = 100;
int rodadas = 0;
Random sorteio = new Random();
int evento = sorteio.Next(1, 5);
Random aleatório = new Random();
int perdeuVidaPerigo = aleatório.Next(5, 25);

while (vida > 0 && rodadas < 10)
{
    evento = sorteio.Next(1, 5);
    rodadas++;

    if (evento == 1)
    {
        vida = vida + 10;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Você encontrou suprimentos!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
    else if (evento == 2)
    {
        vida = vida - 20;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você caiu em uma armadilha.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Perdeu 20 pontos de vida.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
    else if (evento == 3)
    {
        vida = vida + 5;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Você descansou.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
    else if (evento == 4)
    {
        perdeuVidaPerigo = aleatório.Next(5, 25);
        vida = vida - perdeuVidaPerigo;

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Você enfrentou um perigo!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Perdeu " + perdeuVidaPerigo + " de vida.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
}

if (vida > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você sobreviveu aos eventos!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você não conseguiu sobreviver.");
}

Console.ResetColor();


