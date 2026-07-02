// See https://aka.ms/new-console-template for more information
string nome;
int vida;
int pontos;
bool temEspada;
bool temChaveMágica;
bool derrotouChefe;

Console.WriteLine("Digite o nome do personagem: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a sua vida: ");
vida = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de pontos que você tem: ");
pontos = int.Parse(Console.ReadLine());

Console.WriteLine("Você tem espada?(true/false): ");
temEspada = bool.Parse(Console.ReadLine());

Console.WriteLine("Você tem a chave mágica?(true/false): ");
temChaveMágica = bool.Parse(Console.ReadLine());

Console.WriteLine("Você derrotou o chefe?(true/false): ");
derrotouChefe = bool.Parse(Console.ReadLine());

if (vida > 0 && pontos >= 100 && derrotouChefe == true && temChaveMágica || temEspada == true)
{
    Console.WriteLine(nome + " salvou o reino!");
}
else if (vida > 0 && pontos < 100 && derrotouChefe == false && temChaveMágica || temEspada == false)
{
    Console.WriteLine(nome + " sobreviveu, mas não salvou o reino.");
}
else if (vida < 0)
{
    Console.WriteLine(nome + " foi derrotado.");
}