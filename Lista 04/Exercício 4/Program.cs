// See https://aka.ms/new-console-template for more information
string[] fases =
{
    "Floresta", "Caverna", "Castelo", "Laboratório"
};

for (int fase = 0;  fase < fases.Length; fase++)
{
    Console.WriteLine((fase + 1) + " - " + fases[fase]);
    Thread.Sleep(1000);
}
