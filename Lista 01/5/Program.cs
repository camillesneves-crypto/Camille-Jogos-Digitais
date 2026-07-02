// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua energia");
int energia = int.Parse(Console.ReadLine());

{
    if (energia <= 10)
        Console.WriteLine("Energia insuficiente.");
    else if (energia > 10)
        Console.WriteLine("Você pode atacar!");
}

