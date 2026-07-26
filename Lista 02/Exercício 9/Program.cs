// See https://aka.ms/new-console-template for more information
int escolha;
int energia;

Console.WriteLine("Escolha um tipo de ataque:");
Console.WriteLine("1 - Ataque leve");
Console.WriteLine("2 - Ataque pesado");
Console.WriteLine("3 - Especial");
Console.WriteLine("4 - Esquivar");
escolha = int.Parse (Console.ReadLine());

Console.WriteLine("Qual a quantidade de energia que você possui?");
energia = int.Parse (Console.ReadLine());

switch (escolha)
{
    case 1: Console.WriteLine("Você atacou leve!");
        break;
    case 2: if (energia >= 15)
        {
            Console.WriteLine("Você atacou pesado!");
        }
        else { Console.WriteLine("Você não possui energia suficiente para atacar."); }
            break; 
    case 3: if (energia >= 30)
        {
            Console.WriteLine("Você usou o especial!");
        }
    else
        {
            Console.WriteLine("Você não possui energia suficiente para usar o especial.");
        }
        break;
    case 4: if (energia >=10)
        {
            Console.WriteLine("Você esquivou!");
        }
    else
        {
            Console.WriteLine("Você não possui energia suficiente para esquivar.");
        }
        break;
    default: Console.WriteLine("Opção inválida.");
        break; 

}
