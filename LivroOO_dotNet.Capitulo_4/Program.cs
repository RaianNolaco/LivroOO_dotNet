// See https://aka.ms/new-console-template for more information
using LivroOO_dotNet.Capitulo_3.Institucao_de_ensino;

bool sair = false;
while (!sair)
{
    ExecCapitulo_4.intituicao();

    Console.WriteLine("\nDeseja sair ? 1 = sim 2 = Nao");
    switch (Console.ReadLine())
    {
        case "1":
            sair = true;
            break;
    }
    Console.WriteLine("=============================================");
}