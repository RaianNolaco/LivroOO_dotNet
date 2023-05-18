namespace LivroOO_dotNet.Capitulo_4.Funcionario
{
    public class Gerente
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios {
            get { return this.Funcionarios;  }
        
            set{
                if (value == null)
                    removerAntigosDaGerencia(this.Funcionarios);
                else
                    registrarFuncionarios(value);
            }
        }

        private void registrarFuncionarios(List<Funcionario> funcionarios)
        {
            removerAntigosDaGerencia(this.Funcionarios);
            registrarNovosDaGerencia(funcionarios);
        }

        private void registrarNovosDaGerencia(List<Funcionario> funcionarios)
        {
            Funcionario[] funcionarioAdd = new Funcionario[funcionarios.Count];
            funcionarios.CopyTo(funcionarioAdd);

            foreach (var funcionario in funcionarioAdd)
            {
                this.registrarNaGerencia(funcionario);
            }
        }

        private void registrarNaGerencia(Funcionario funcionario)
        {
            if (funcionario.Gerente == null || funcionario.Gerente.Equals(this))
                funcionario.Gerente = this;
        }

        private void registrarFuncionario(Funcionario funcionario)
        {
            removerDa
        }

        private void removerAntigosDaGerencia(List<Funcionario> funcionarios)
        {
            Funcionario[] funcionariosRemover = new Funcionario[funcionarios.Count];

            funcionarios.CopyTo(funcionariosRemover);

            foreach (var funcionario in funcionariosRemover)
            {
                removerAntigosDaGerencia(funcionario);
            }
        }

        private void removerAntigosDaGerencia(Funcionario funcionario)
        {
            if (funcionario.Gerente != null)
                funcionario.Gerente = null;
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;

            if(obj is Gerente)
            {
                Gerente g = obj as Gerente;
                return this.Nome.Equals(g.Nome);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.Nome == null? 0 : this.Nome.GetHashCode());
        }
    }
}