// See https://aka.ms/new-console-template for more information
int moedas;
bool derrotouChefe;
int vida;

Console.Write("Quantidade de moedas que você coletou: ");
moedas = int.Parse(Console.ReadLine());

Console.Write("Você derrotou o chefe? (true/false): ");
derrotouChefe = bool.Parse(Console.ReadLine());

Console.Write("Vida final: ");
vida = int.Parse(Console.ReadLine());

if (moedas >= 10 && derrotouChefe && vida > 0)
{
    Console.WriteLine("Fase concluída!");
}
else
{
    Console.WriteLine("Você não cumpriu todos os objetivos.");
}
