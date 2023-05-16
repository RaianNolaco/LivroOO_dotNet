namespace LivroOO_dotNet.Capitulo_4.Funcionario
{
    public class Gerente
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }
}