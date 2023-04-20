using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_3
{
    public static class ExecCapitulo_3
    {
        public static void intituicao()
        {
            var iesUTFPR = new Instituicao() {
                Nome = "UTFPR",
                Endereco = "Medianeira"
            };
            

            var iesCC = new Instituicao() {
                Nome = "Casa do codigo",
                Endereco = "São paulo"
            };
         

            var depEnsino = new Departamento("Computação");
            var depAlimentos = new Departamento("Alimentos");
            var depRevisao = new Departamento("Revisão escrita");

            iesUTFPR.RegistrarDepartamento(depEnsino);
            iesUTFPR.RegistrarDepartamento(depAlimentos);

            iesCC.RegistrarDepartamento(depRevisao);

            Console.WriteLine(iesUTFPR.Nome);
            for (int i = 0; i < iesUTFPR.ObterQntDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }

            Console.WriteLine(iesUTFPR.Nome);
            for (int i = 0; i < iesUTFPR.ObterQntDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }


        }
    }
}
