using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_3.Livraria
{
    public class Editora
    {
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public Livro[] Livros { get; set; } = new Livro[10];

        public int qntLivros = 0;

        public void registrarLivro(Livro livro)
        {
            if (this.qntLivros <10)
            
            Livros[qntLivros] = livro;
        }
    }
}
