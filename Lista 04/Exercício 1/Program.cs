// See https://aka.ms/new-console-template for more information
string[] personagens =
{
    "Kai", "Mika", "Luna"
};

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(personagens[0]);
Console.ResetColor();
Thread.Sleep(2000);
Console.ForegroundColor= ConsoleColor.Yellow;
Console.WriteLine(personagens[1]);
Console.ResetColor();
Thread.Sleep(2000);
Console.ForegroundColor= ConsoleColor.DarkGreen;
Console.WriteLine(personagens[2]);  
Console.ResetColor();