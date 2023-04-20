namespace LivroOO_dotNet.Capitulo_3
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Departamento[] Departamentos { get; set; } = new Departamento[10];
        private int qntDepartamentos { get; set; }

        public void RegistrarDepartamento(Departamento dep)
        {
            if (qntDepartamentos < 10)
                this.Departamentos[qntDepartamentos++] = dep;
        }

        public int ObterQntDepartamentos()
        {
            return this.qntDepartamentos;
        }

        public Departamento ObterDepartamentoPorIndice(int indice)
        {
            return this.Departamentos[indice];
        }
    }
}
