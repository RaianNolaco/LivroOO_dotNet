using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_4.Funcionario
{
    public  class Funcionario
    {
        public string Nome { get; set; }
        private Gerente gerente;
        public Gerente Gerente {
            get { return this.gerente}
            set
            {
                if (this.gerente != null)
                    this.gerente.Funcionarios.Remove(this);

                this.gerente = value;

                if(this.gerente != null)
            }
        }
    }
}
