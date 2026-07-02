// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual é a sua vida?");
int vida = int.Parse(Console.ReadLine());
Console.WriteLine("Quanto de cura você recebeu?");
int cura = int.Parse(Console.ReadLine());
int vidafinal = (vida + cura);
Console.WriteLine("Vida atual: " + vida);
Console.WriteLine("Quantidade de cura: " + cura);
if (vida + cura <= 0)
{
    Console.WriteLine("Vida final: 100");
}
else
{
    Console.WriteLine("Vida final: " + (vida + cura));
}