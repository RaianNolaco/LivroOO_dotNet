namespace LivroOO_dotNet.Capitulo_4
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Disciplina)
            {
                Disciplina c = obj as Disciplina;
                return this.Nome.Equals(c.Nome);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
        }
    }
}
