// See https://aka.ms/new-console-template for more information
bool primeiraVez;
bool verTutorial;

Console.WriteLine("É a sua primeira vez jogando?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
int opção = int.Parse (Console.ReadLine());
if (opção == 1)
{
    primeiraVez = true;
}
else
{
    primeiraVez = false;
}

Console.WriteLine("Você quer ver o tutorial?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
int opção2 = int.Parse(Console.ReadLine());
if (opção2 == 1)
{
    verTutorial = true;
}
else
{
    verTutorial = false;
}



if (primeiraVez && verTutorial)
{
    Console.WriteLine("Iniciando tutorial...");
}
else
{
    Console.WriteLine("Tutorial pulado. Boa sorte!");
}