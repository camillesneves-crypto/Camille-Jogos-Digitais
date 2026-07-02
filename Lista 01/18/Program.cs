// See https://aka.ms/new-console-template for more information
int moeda;
int preço;
string nome;

Console.Write("Digite a quantidade de moedas: ");
moeda = int.Parse(Console.ReadLine());

Console.Write("Digite o preço do item: ");
preço = int.Parse(Console.ReadLine());

Console.Write("Digite o nome do item: ");
nome = Console.ReadLine();

if (preço < moeda)
{
    Console.WriteLine(moeda - preço);
    Console.WriteLine("O item comprado foi: " + nome);
    Console.WriteLine("A quantidade de moedas que sobrou foi: " + (moeda - preço));
}
else
{
    Console.WriteLine("Você não tem moedas suficientes para comprar esse item.");
}