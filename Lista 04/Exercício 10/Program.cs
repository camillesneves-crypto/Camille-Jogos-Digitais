string[] nomes = { "Luna", "Kai", "Mika" };
int[] vidas = { 100, 80, 50 };

for  (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i] + " - Vida: " + vidas[i]);
    Thread.Sleep(1000);

}

for (int i = 0;i < vidas.Length; i++)
{
    if (vidas[i] >= 70)
    {
        Console.WriteLine(nomes[i] + " - Vida: " + vidas[i] + " - Saudável.");
    }
    else
    {
        Console.WriteLine(nomes[i] + " - Vida: " + vidas[i] + " - Ferido.");
    }
    Thread.Sleep(1000);
}
