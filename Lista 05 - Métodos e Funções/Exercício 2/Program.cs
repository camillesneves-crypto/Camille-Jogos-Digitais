// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Cyan;
MostrarDialogo("Luna - A guardiã", "Eu protejo esta floresta há muitos anos. Sei que o caminho será difícil, mas acredito que você tem coragem suficiente para enfrentar os desafios. Nunca se esqueça: a natureza sempre revela o caminho para aqueles que sabem ouvir.");
Console.ResetColor();
Thread.Sleep(2000);

Console.ForegroundColor = ConsoleColor.Green;
MostrarDialogo("Kai - O guerreiro", "Eu já enfrentei muitos inimigos pelo mundo, mas nunca encontrei uma missão como esta. Se quisermos vencer, teremos que trabalhar juntos e confiar uns nos outros. Prepare-se, porque a aventura começa agora.");
Console.ResetColor();
Thread.Sleep(2000);

Console.ForegroundColor = ConsoleColor.White;
MostrarDialogo("Mika - A exploradora", "Encontrei pistas sobre um antigo segredo escondido nesta região. Ainda não sabemos o que vamos encontrar, mas cada descoberta nos deixa mais perto da verdade. Vamos explorar e descobrir o que está esperando por nós!");
Console.ResetColor();

void MostrarDialogo (string personagem, string texto)
{
    Console.WriteLine (personagem + ": " + texto);
}
