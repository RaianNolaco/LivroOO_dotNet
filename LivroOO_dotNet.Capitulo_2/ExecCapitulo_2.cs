using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_2
{
    public static class ExecCapitulo_2
    {
        public static void instituicao()
        {
            Instituicao instituicao = new Instituicao();

            Console.WriteLine("Informe o nome da intituição: ");
            instituicao.nome = Console.ReadLine();

            Console.WriteLine("Informe o endereco da intituição:");
            instituicao.endereco = Console.ReadLine();

            Console.WriteLine("==============================================");
            Console.WriteLine($"Obrigado por informar os dados para instituição {instituicao.nome}.");

        }

        public static void circulo()
        {
            Circulo circulo = new Circulo();

            Console.WriteLine("Informe o raio do circulo: ");
            circulo.Raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("==============================================");

            Console.WriteLine("Aréa: " + circulo.Area());
            Console.WriteLine("Comprimento: " + circulo.Comprimento());
        }
    }
}
