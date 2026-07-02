// See https://aka.ms/new-console-template for more information
int reputação;
bool entregouPresente;
int opção; 

Console.WriteLine("Escreva o seu nível de reputação");
reputação = int.Parse(Console.ReadLine());

Console.WriteLine("Você deseja entregar um presente ao NPC?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
opção = int.Parse(Console.ReadLine());

if (opção == 1)
{
    entregouPresente = true;
}
else
{
    entregouPresente = false;
}

if (reputação >= 50 || entregouPresente == true)
{
    Console.WriteLine("O NPC revelou uma informação secreta.");
}
else
{
    Console.WriteLine("O NPC não confia em você ainda.");
}