// See https://aka.ms/new-console-template for more information
int escolha;

Console.WriteLine("Escolha um símbolo:");
Console.WriteLine("1 - Lua");
Console.WriteLine("2 - Sol");
Console.WriteLine("3 - Estrela");
Console.WriteLine("4 - Chama");
escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1: Console.WriteLine("Uma ponte apareceu.");
        break;
    case 2: Console.WriteLine("A sala ficou iluminada.");
        break;
    case 3: Console.WriteLine("Um item secreto surgiu."); 
        break;
    case 4: Console.WriteLine("Uma armadilha foi ativada.");
        break;
    default: Console.WriteLine("Nada aconteceu.");
        break;
}