// See https://aka.ms/new-console-template for more information
Console.WriteLine("Você tem a chave? (true/false)");
string key = Console.ReadLine();

bool temChave = key == "true";
{
    if (temChave == false)
        Console.WriteLine("A porta está trancada!");
    else
        Console.WriteLine("A porta abriu.");
}

