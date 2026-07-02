// See https://aka.ms/new-console-template for more information
string nome = "";
int idade = 0;


Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();
Console.WriteLine("Qual a sua idade?");
idade = int.Parse (Console.ReadLine());

if (nome == "luca oreia" && idade >= 18)
{
    Console.WriteLine(nome + " pode ser preso");

}
else
{
    Console.WriteLine(nome + " não pode ser preso");
}



if (nome == "oreia" || idade >= 18)
{
    Console.WriteLine(nome + " pode ser preso");

}
else
{
    Console.WriteLine(nome + " não pode ser preso");
}

//Switch
string casa_hp = "";
Console.WriteLine( "qual a sua casa do harry potter?" +
    "\nOpção 1: Grifinória" +
    "\nOpção 2: Sonserina" +
    "\nOpção 3: Lufa Lufa" +
    "\nOpção 4: Corvinal"); 
casa_hp = Console.ReadLine();
switch (casa_hp)
{
    case "Grifinória":
        Console.WriteLine("você está na casa do harry potter");
        break;
    case "Sonserina":
        Console.WriteLine("você está na casa do draco malfoy");
        break;
    case "Lufa Lufa":
        Console.WriteLine("você está na casa do cedrico");
        break;
    case "Corvinal": 
        Console.WriteLine("você está na casa da luna");
        break;
    default:
        Console.WriteLine("você não entendeu, tente de novo");
        break;
}