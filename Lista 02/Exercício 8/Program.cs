// See https://aka.ms/new-console-template for more information
int bateria;
int opção;
int opção2;
bool monstroTela;
bool gravando;

Console.WriteLine("Informe a quantidade de bateria da camêra.");
bateria = int.Parse(Console.ReadLine());

Console.WriteLine("Você começou a gravar?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
opção2 = int.Parse(Console.ReadLine());

Console.WriteLine("Tem algum monstro na tela?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");
opção = int.Parse(Console.ReadLine());


if (opção2 == 1)
{
    gravando = true;
}
else
{
    gravando = false;
}
if (opção == 1)
{
    monstroTela = true;
} 
else
{
    monstroTela = false;
}

if (bateria > 0 && gravando == true &&  monstroTela == true)
{
    Console.WriteLine("Cena assustadora gravada!");
}
else if (monstroTela == false)
{
    Console.WriteLine("Você gravou, mas nada interessante apareceu.");
}
else if (bateria == 0)
{
Console.WriteLine("A câmera está sem bateria.");
}
else
{
    Console.WriteLine("Você não gravou nada.");
}