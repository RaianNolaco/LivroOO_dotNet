namespace LivroOO_dotNet.Capitulo_3.Institucao_de_ensino
{
    public static class ExecCapitulo_3
    {
        public static void intituicao()
        {
            var iesUTFPR = new Instituicao()
            {
                Nome = "UTFPR",
                Endereco = new Endereco{ 
                    Rua =" Rua x",
                    Bairro = "Bairro y",
                    Numero = "12"
                }
            };


            var iesCC = new Instituicao()
            {
                Nome = "Casa do codigo",
                Endereco = new Endereco{
                    Rua =" Rua A",
                    Bairro = "Bairro B",
                    Numero = "132B"
                }
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
            Console.WriteLine($"==> {iesUTFPR.Endereco.Rua}");


            Console.WriteLine(iesCC.Nome);
            for (int i = 0; i < iesCC.ObterQntDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}");
            }
            Console.WriteLine($"==> {iesCC.Endereco.Rua}");


        }
    }
}
