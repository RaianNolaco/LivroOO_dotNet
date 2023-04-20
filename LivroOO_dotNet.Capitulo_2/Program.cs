// See https://aka.ms/new-console-template for more information
using LivroOO_dotNet.Capitulo_2;

bool sair = false;
while (!sair)
{
    //Executar.instituicao();
    ExecCapitulo_2.circulo();

    Console.WriteLine("\nDeseja sair ? 1 = sim 2 = Nao");
	switch (Console.ReadLine())
	{
		case "1":
			sair = true;
			break;
	}
	Console.WriteLine("=============================================");
}

