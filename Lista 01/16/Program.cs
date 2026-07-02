// See https://aka.ms/new-console-template for more information
bool temChave;
int nivel;

Console.Write("Tem chave? (true/false): ");
temChave = bool.Parse(Console.ReadLine());

Console.Write("Digite o nível: ");
nivel = int.Parse(Console.ReadLine());

if (temChave || nivel >= 5)
{
    Console.WriteLine("O baú foi aberto!");
}
else
{
    Console.WriteLine("Você não conseguiu abrir o baú.");
}