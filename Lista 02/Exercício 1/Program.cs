// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escolha seu nível de dificuldade: ");
Console.WriteLine("1 - Fácil");
Console.WriteLine("2 - Normal");
Console.WriteLine("3 - Difícil");

int escolha = int.Parse (Console.ReadLine());

switch (escolha)
{
    case 1: Console.WriteLine("Fácil: 5 vidas, dano do inimigo é 10, 3 checkpoints");
        break;
    case 2: Console.WriteLine("Normal: 3 vidas, dano do inimigo é 20, 2 checkpoints");
        break;
    case 3: Console.WriteLine("Difícil: 1 vida, dano do inimigo é 35, 0 checkpoints");
        break;
    default: Console.WriteLine("Dificuldade inválida.");
        break;
}
