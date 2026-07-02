// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua pontuação inicial");
int pontuaçãoinicial = int.Parse(Console.ReadLine());

{
    if (pontuaçãoinicial <= 0)
        Console.WriteLine("Você ainda não tem pontos!");
    else if (pontuaçãoinicial > 0)
        Console.WriteLine("Você já começou pontuando!");
};
