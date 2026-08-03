// See https://aka.ms/new-console-template for more information
string[] ItensDeJogo =
{
    "Poção", "Espada", "Escudo", "Mapa"
};

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Primeiro item: " + ItensDeJogo [0]);
Console.ResetColor();
Thread.Sleep (1500);

Console.ForegroundColor= ConsoleColor.Yellow;
Console.WriteLine("Segundo item: " + ItensDeJogo [1]);
Console.ResetColor();
Thread.Sleep(1500);

Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine("Terceiro item: " + ItensDeJogo [2]);
Console.ResetColor();
Thread.Sleep(1500);

Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.WriteLine("Último item: " + ItensDeJogo [3]);
Console.ResetColor();