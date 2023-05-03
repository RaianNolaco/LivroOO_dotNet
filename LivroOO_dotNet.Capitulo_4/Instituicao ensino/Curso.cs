namespace LivroOO_dotNet.Capitulo_4
{
    public class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public HashSet<Disciplina> Disciplinas { get; set; } = new HashSet<Disciplina>();

        public void RegistrarDisciplna(Disciplina dic)
        {
            Disciplinas.Add(dic);
        }

        public int ObterQuantidadeDisciplinas()
        {
            return Disciplinas.Count;
        }

        public Disciplina ObterDisciplinaPorNome(string nome)
        {
            return Disciplinas.Where<Disciplina>(d => d.Nome.Equals(nome)).FirstOrDefault();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Curso){
                Curso c = obj as Curso;
                return this.Nome.Equals(c.Nome);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + this.Nome == null? 0: this.Nome.GetHashCode());
        }
    }
}
