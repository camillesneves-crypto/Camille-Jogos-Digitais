// See https://aka.ms/new-console-template for more information
Console.WriteLine("Preencha as seguintes informações respectivamente: Nome do seu personagem; Classe; Energia; Vida.");
string nomepersonagem = Console.ReadLine();
string classepersonagem = Console.ReadLine();
int energiapersonagem = int.Parse(Console.ReadLine());
int vidapersonagem = int.Parse(Console.ReadLine());
if (vidapersonagem >= 1)
{
    Console.WriteLine("Personagem pronto para a aventura.");
}
else
{
    Console.WriteLine("Personagem inválido: vida precisa ser maior que zero.");
}
