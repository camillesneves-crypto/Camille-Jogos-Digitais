string[] inimigos = { "Slime", "Morcego", "Goblin", "Esqueleto" };

Console.WriteLine("Inimigos encontrados: ");
Thread.Sleep(2000);
for (int i = 0; i < inimigos.Length; i++)
{
    Console.WriteLine("Um " + inimigos[i] + " apareceu!");  
Thread.Sleep(1000);
}
