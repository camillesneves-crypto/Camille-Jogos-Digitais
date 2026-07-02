// See https://aka.ms/new-console-template for more information
bool escondido;
int barulho;
bool inimigoOlhando;

Console.WriteLine("Você está escondido?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não"); 
int opção1 = int.Parse(Console.ReadLine());

if (opção1==2)
{
    escondido = false;
}
else
{
    escondido=true;
}

Console.WriteLine("Qual o nível de barulho que você fez? (em números)");
barulho = int.Parse(Console.ReadLine());

Console.WriteLine("O inimigo está olhando para você?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
int opção2 = int.Parse(Console.ReadLine());

if (opção2 ==2)
{
    inimigoOlhando = false;
}
else
{
    inimigoOlhando = true;
}

if (escondido && inimigoOlhando || barulho > 70)
{
    Console.WriteLine("Você foi detectado!");
}
else
{
    Console.WriteLine("Você passou despercebido.");
}