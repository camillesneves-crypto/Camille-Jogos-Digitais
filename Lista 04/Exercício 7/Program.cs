// See https://aka.ms/new-console-template for more information
int[] partidas = { 80, 120, 60, 200, 150 };
int maior = partidas[0];

for (int i = 1; i < partidas.Length; i++)
{
   if (partidas[i] > maior)
    {
        maior = partidas[i];
    } 
}

Console.WriteLine("Maior pontuação: " + maior);