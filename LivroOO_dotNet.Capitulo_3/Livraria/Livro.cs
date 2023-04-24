using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_3.Livraria
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }

        private Editora editora;
        public Editora Editora
        { 
            get { return this.editora; }
            set
            {
                this.editora = value;
                this.editora.registrarLivro(this);
            }
        }
        public Autor[] Autores { get; set; } = new Autor[5];


    }
}
