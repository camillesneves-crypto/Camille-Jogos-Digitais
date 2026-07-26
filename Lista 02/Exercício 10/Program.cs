// See https://aka.ms/new-console-template for more information
string escolhaÁrea;
string evento;
int nível;
int possuiItem;
int possuiAliado;

Console.WriteLine("Escolha uma área:");
Console.WriteLine("Floresta");
Console.WriteLine("Ruínas");
Console.WriteLine("Laboratório");
Console.WriteLine("Praia"); 
escolhaÁrea = (Console.ReadLine());

switch (escolhaÁrea)
{
    case "Floresta": evento = "Um animal selvagem apareceu!";
        Console.WriteLine(evento);
        break;

    case "Ruínas": evento = "Uma armadilha antiga foi ativada!";
        Console.WriteLine(evento);
        break;

    case "Laboratório": evento = "Um robô descontrolado apareceu!";
        Console.WriteLine(evento);
        break;

    case "Praia": evento = "Uma tempestade repentina começou!";
        Console.WriteLine(evento);
        break;

    default: evento = "Opção inválida.";
        Console.WriteLine(evento);
        break;
}

Console.WriteLine("Informe o nível do seu personagem.");
nível = int.Parse(Console.ReadLine());

Console.WriteLine("Você possui um item especial?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
possuiItem = int.Parse (Console.ReadLine());

Console.WriteLine("Você está com algum aliado?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
possuiAliado = int.Parse (Console.ReadLine());

if (nível>=5 && possuiItem == 1 || possuiAliado==1)
{
    Console.WriteLine("Área escolhida: " + escolhaÁrea );
    Console.WriteLine("Evento: " + evento);
    Console.WriteLine("Você resolveu este evento com sucesso!");
}
else
{
    Console.WriteLine("Área escolhida: " + escolhaÁrea);
    Console.WriteLine("Evento: " + evento);
    Console.WriteLine("Você não estava preparado para esse evento.");
}
