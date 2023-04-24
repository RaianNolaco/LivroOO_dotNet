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
    }
}
