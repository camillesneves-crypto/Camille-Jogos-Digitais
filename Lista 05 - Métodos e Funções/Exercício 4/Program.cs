// See https://aka.ms/new-console-template for more information
int ataque = 0;
int defesa = 0;
int bonus = 0;
int danoFinal = 0;  

LerDados();
CalcularDano();
ResultadoFinal();



void LerDados()
{
    Console.WriteLine("Digite o valor do ataque: ");
    ataque = int.Parse (Console.ReadLine());
    if (ataque < 0)
    {
        Console.WriteLine("O ataque não pode ser negativo.");
        return;
    }

    Console.WriteLine("Digite o valor da defesa: ");
    defesa = int.Parse (Console.ReadLine());
    if (defesa < 0)
    {
        Console.WriteLine("A defesa não pode ser negativa.");
        return;
    }

    Console.WriteLine("Digite o valor do bônus de combate: ");
    bonus = int.Parse (Console.ReadLine());
    if (bonus < 0)
    {
        Console.WriteLine("O bônus não pode ser negativo.");
        return;
    }
}

void CalcularDano()
{ 
        danoFinal = ataque + bonus - defesa;
}

void ResultadoFinal()
{
    if (danoFinal <= 0)
    {
        Console.WriteLine("O dano final foi: 0");
    }
    else
    {
        Console.WriteLine("O dano final foi: " + danoFinal);
    }
    
}