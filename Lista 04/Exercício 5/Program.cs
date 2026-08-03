// See https://aka.ms/new-console-template for more information
int[] pontos = { 100, 250, 300, 150, 400 };

for (int i = 0; i < pontos.Length; i++)
{
    Console.WriteLine("Fase " + (i + 1) + ": " + pontos[i] + " pontos");
    Thread.Sleep(1000);
}
