// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual o seu nível?");
int nivel = Console.ReadLine();
if (nivel < 5)
{
    Console.WriteLine("Iniciante");
}
else if (nivel <= 10)
{
    Console.WriteLine("Aventureiro");
}
else
{
    Console.WriteLine("Herói experiente");
}
