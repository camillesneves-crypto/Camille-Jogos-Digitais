// See https://aka.ms/new-console-template for more information
int passos = 0;

while (passos <= 10)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O personagem deu mais um passo.");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Passos atuais: " + passos);
    Console.ResetColor();
    Thread.Sleep(1500);

    passos++;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Você chegou ao seu destino.");
Console.ResetColor();
