// See https://aka.ms/new-console-template for more information
int energia = 100;

Random sorteio = new Random();
int gastoEnergia = sorteio.Next(5, 21);

while (energia > 0)
{
    gastoEnergia = sorteio.Next(5, 21);
    energia = energia - gastoEnergia;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A lanterna gastou " + gastoEnergia + " de energia");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Energia atual: " + energia);
    Console.ResetColor();
    Thread.Sleep(1500);
}

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("A lanterna apagou.");
Console.ResetColor();
