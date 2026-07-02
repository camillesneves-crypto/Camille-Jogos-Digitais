// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escolha o clima da fase: ");
Console.WriteLine("1 - Sol");
Console.WriteLine("2 - Chuva");
Console.WriteLine("3 - Neve");
Console.WriteLine("4 - Tempestade");

int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Sol: velocidade normal.");
        break;
    case 2:
        Console.WriteLine("Chuva: jogador escorrega.");
        break;
    case 3:
        Console.WriteLine("Neve: velocidade reduzida.");
        break;
    case 4:
        Console.WriteLine("Tempestade: visão reduzida e risco maior.");
        break;
    default:
        Console.WriteLine("Clima inválido.");
        break;
}