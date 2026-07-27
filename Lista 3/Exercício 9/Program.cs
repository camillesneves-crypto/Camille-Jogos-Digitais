// See https://aka.ms/new-console-template for more information
int pontuação = 0;
Random sorteio = new Random();
int pontosSorteados = sorteio.Next(5, 16);

while (pontuação < 50)
{
    pontosSorteados = sorteio.Next(5, 16);
    pontuação = pontosSorteados + pontuação;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você ganhou " + pontosSorteados + " pontos!");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Pontuação atual: " + pontuação);
    Console.ResetColor();
    Thread.Sleep(1500);
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Objetivo concluído!");
Console.ResetColor();

