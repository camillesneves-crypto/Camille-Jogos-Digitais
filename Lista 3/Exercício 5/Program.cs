// See https://aka.ms/new-console-template for more information
int tentativa = 0;

Random sorteio = new Random();
int númeroSecreto = sorteio.Next(1, 21);

while (tentativa != númeroSecreto)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Digite um número entre 1 e 20:");
    Console.ResetColor();

    tentativa = int.Parse(Console.ReadLine());

    if (tentativa < númeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("O número secreto é maior.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
    else if (tentativa > númeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("O número secreto é menor.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
    else if (tentativa == númeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parabéns! Você acertou o número secreto.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
} 