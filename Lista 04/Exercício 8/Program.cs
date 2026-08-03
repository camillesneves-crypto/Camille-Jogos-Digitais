using System.Text;

string[] inventario = { "Poção", "Mapa", "Chave", "Cristal" };
bool encontrou = false;

Console.WriteLine("Digite o nome de um item: ");
string resposta = Console.ReadLine();

for  (int i = 0; i < inventario.Length; i++)
{
    if (resposta == inventario[i] )
    {
        encontrou = true;
        Console.WriteLine("Item encontrado!");
    }
   
}

if (encontrou == false)
{
    Console.WriteLine("Item não encontrado.");
}

