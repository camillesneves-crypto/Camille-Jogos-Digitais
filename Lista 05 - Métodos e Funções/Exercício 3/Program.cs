// See https://aka.ms/new-console-template for more information
string nome = "";
string classe = "";

int vida = 0;
int energia = 0;
int forca = 0;
int moedas = 0;
int pontuacao = 0;


LerDados();

CalcularPontuacao();

MostrarFicha();



void LerDados()
{
    Console.Write("Digite o nome do personagem: ");
    nome = Console.ReadLine();

    Console.Write("Digite a classe do personagem: ");
    classe = Console.ReadLine();

    Console.Write("Digite a vida: ");
    vida = int.Parse(Console.ReadLine());

    Console.Write("Digite a energia: ");
    energia = int.Parse(Console.ReadLine());

    Console.Write("Digite a força: ");
    forca = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade de moedas: ");
    moedas = int.Parse(Console.ReadLine());
}


void CalcularPontuacao()
{
    pontuacao = vida + energia + forca + moedas;
}


void MostrarFicha()
{
    Console.WriteLine("===== FICHA DO PERSONAGEM =====");

    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Classe: " + classe);
    Console.WriteLine("Vida: " + vida);
    Console.WriteLine("Energia: " + energia);
    Console.WriteLine("Força: " + forca);
    Console.WriteLine("Moedas: " + moedas);
    Console.WriteLine("Pontuação geral: " + pontuacao);
}
