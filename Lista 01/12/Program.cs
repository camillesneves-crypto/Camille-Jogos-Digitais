// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escolha um caminho: ");
Console.WriteLine("1 - Floresta");
Console.WriteLine("2 - Caverna");
Console.WriteLine("3 - Castelo");

int escolha = int.Parse (Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Você entrou na floresta.");
            break;
    case 2:
        Console.WriteLine("Você entrou na caverna.");
            break;
    case 3:
        Console.WriteLine("Você entrou no castelo.");
            break;
    default:
        Console.WriteLine("Opção inválida");
        break;  

}

