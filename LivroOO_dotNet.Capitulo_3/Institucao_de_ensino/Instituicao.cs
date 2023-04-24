namespace LivroOO_dotNet.Capitulo_3.Institucao_de_ensino
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
                Departamentos[qntDepartamentos++] = dep;
        }

        public int ObterQntDepartamentos()
        {
            return qntDepartamentos;
        }

        public Departamento ObterDepartamentoPorIndice(int indice)
        {
            return Departamentos[indice];
        }
    }
}
