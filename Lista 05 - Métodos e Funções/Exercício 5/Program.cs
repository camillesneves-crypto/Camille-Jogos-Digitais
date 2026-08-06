// See https://aka.ms/new-console-template for more information
int vidaAtual = 0;
int cura = 0;
int vidaMaxima = 0;
int novaVida = 0;

LerDados();
CalcularVida();
ValorFinal();

void LerDados()
{
    Console.WriteLine("Digite o valor da sua vida atual: ");
    vidaAtual = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor da cura: ");
    cura = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor máximo de vida que um personagem pode ter: ");
    vidaMaxima = int.Parse(Console.ReadLine());
}

void CalcularVida()
{
    novaVida = vidaAtual + cura;
    if (novaVida > vidaMaxima)
    {
        novaVida = vidaMaxima;
    }
}

void ValorFinal()
{
    Console.WriteLine("Vida inicial: " + vidaAtual);
    Console.WriteLine("Vida final: " + novaVida);
}


