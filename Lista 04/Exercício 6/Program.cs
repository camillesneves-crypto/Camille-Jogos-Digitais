// See https://aka.ms/new-console-template for more information
int[] pontos =
{
    100, 250, 300, 150, 400
};

int total = 0;

for (int i = 0; i < pontos.Length;i++)
{
    total += pontos[i];
}

Console.WriteLine("Pontuação total: " + total);