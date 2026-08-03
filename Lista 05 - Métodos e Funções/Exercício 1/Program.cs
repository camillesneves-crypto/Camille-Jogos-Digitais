// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome para começar: ");
string jogador = Console.ReadLine();

MostrarTitulo();
MostrarHistoria();
MostrarMensagem();



void MostrarTitulo()
{
    Console.WriteLine("=== A Aventura Perdida ===");
}

void MostrarHistoria()
{
    Console.WriteLine("Você acordou em uma floresta misteriosa.");
    Console.WriteLine("Seu objetivo é encontrar o caminho de volta.");
}

void MostrarMensagem()
{
    Console.WriteLine("Boa sorte, " + jogador + "! Sua aventura começa agora.");
}
