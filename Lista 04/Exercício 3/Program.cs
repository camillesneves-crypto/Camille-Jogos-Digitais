// See https://aka.ms/new-console-template for more information
using System;

string[] itens =
{
    "Poção", "Chave", "Mapa", "Espada", "Cristal"
};

for (int item = 0; item < itens.Length; item++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(itens[item]);
    Console.ResetColor();
    Thread.Sleep(1500);
}
