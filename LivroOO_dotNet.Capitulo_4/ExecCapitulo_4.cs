using LivroOO_dotNet.Capitulo_4;

namespace LivroOO_dotNet.Capitulo_3.Institucao_de_ensino
{
    public static class ExecCapitulo_4
    {
        public static void intituicao()
        {
            var depAlimentos = new Departamento("Alimentos");

            depAlimentos.RegistrarCurso(
                    new Curso{
                        Nome ="Tecnologia em Alimentos",
                        CargaHoraria = 3000
                    }
                );

            depAlimentos.RegistrarCurso(
                    new Curso
                    {
                        Nome = "Engenharia de Alimentos",
                        CargaHoraria = 3000
                    }
                );

            Console.WriteLine($"\n\nCursos no departamento de {depAlimentos.Nome}");

            foreach (var curso in depAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.CargaHoraria}h)");
            }

            depAlimentos.fecharDepartamento();


        }
    }
}
