// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a pontuação:");
int pontos = int.Parse(Console.ReadLine());

if (pontos < 100)
{
    Console.WriteLine("Rank C");
}
else if (pontos <= 299)
{
    Console.WriteLine("Rank B");
}
else if (pontos <= 499)
{
    Console.WriteLine("Rank A");
}
else
{
    Console.WriteLine("Rank S");
}
