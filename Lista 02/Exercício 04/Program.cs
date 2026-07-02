// See https://aka.ms/new-console-template for more information
int madeira;
int pedra;

Console.WriteLine("Qual a quantidade de madeiras que você possui?");
madeira = int.Parse (Console.ReadLine());

Console.WriteLine("Qual a quantidade de pedras que você possui?");
pedra = int.Parse (Console.ReadLine());

Console.WriteLine("Você possui a receita?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
int opção = int.Parse(Console.ReadLine());

if (madeira > 3 && pedra > 2 && opção == 1)
{
    Console.WriteLine("Lança criada com sucesso!");
}
else
{
    Console.WriteLine("Você não possui os recursos necessários.");
}