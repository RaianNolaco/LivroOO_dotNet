using LivroOO_dotNet.Capitulo_4;

namespace LivroOO_dotNet.Capitulo_3.Institucao_de_ensino
{
    public static class ExecCapitulo_4
    {
        public static void intituicao()
        {
            var depAlimentos = new Departamento("Alimentos");

            depAlimentos.RegistrarCurso(
                    new Curso {
                        Nome = "Tecnologia em Alimentos",
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

            var ctAlimentos = new Curso
            {
                Nome = "Tecnologia em Alimentos",
                CargaHoraria = 2000
            };

            if (!depAlimentos.Cursos.Contains(ctAlimentos))
            {
                depAlimentos.RegistrarCurso(ctAlimentos);
            }

            var cursoCC = new Curso()
            {
                Nome = "Ciência da Computação",
                CargaHoraria = 3000
            };

            var disc = new Disciplina()
            {
                Nome = "Algoritimos",
                CargaHoraria = 80
            };

            cursoCC.RegistrarDisciplna(disc);

            cursoCC.RegistrarDisciplna(
                 new Disciplina()
                 {
                    Nome = "Orientação a Objetos",
                    CargaHoraria = 60
                 }
             );

            cursoCC.RegistrarDisciplna(
                 new Disciplina()
                 {
                    Nome = "Orientação a Objetos",
                    CargaHoraria = 80
                 }
             );

            cursoCC.RegistrarDisciplna(
                 new Disciplina()
                 {
                    Nome = "Estrutura de Dados",
                    CargaHoraria = 80
                 }
             );

            cursoCC.RegistrarDisciplna(
                new Disciplina()
                {
                    Nome = "Programação para web",
                    CargaHoraria = 80
                }
             );




            Console.WriteLine($"\n\nCursos no departamento de {depAlimentos.Nome}");

            foreach (var curso in depAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.CargaHoraria}h)");
            }

            Console.WriteLine();

            Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.ObterQuantidadeDisciplinas()} disciplinas:");
            foreach(var disciplina in cursoCC.Disciplinas)
            {
                Console.WriteLine($"==> {disciplina.Nome} ({disciplina.CargaHoraria})");
            }

            Console.WriteLine();

            depAlimentos.fecharDepartamento();



        }
    }
}
