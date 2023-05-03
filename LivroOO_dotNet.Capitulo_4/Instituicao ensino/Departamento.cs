using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_4
{
    public class Departamento
    {
        public string Nome { get; set; }
        public IList<Curso> Cursos { get; } = new List<Curso>();

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public void RegistrarCurso(Curso NovoCurso)
        {
            Cursos.Add(NovoCurso);
        }

        public int ObterQuantidadeCurso()
        {
            return Cursos.Count;
        }

        public Curso ObterCursoPorIndice(int indice)
        {
            return Cursos[indice];
        }

        public void fecharDepartamento()
        {
            while (Cursos.Count >0)
            {
                Console.WriteLine($"Removendo curso: {Cursos[0].Nome}");
                Cursos.RemoveAt(0);
            }

            Console.WriteLine("Departamento fechado");
        }
    }
}
