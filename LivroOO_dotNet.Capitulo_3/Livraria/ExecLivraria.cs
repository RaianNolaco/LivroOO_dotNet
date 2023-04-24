using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_3.Livraria
{
    public static class ExecLivraria
    {
        public static void Executar()
        {
            Autor autor1 = new Autor();
            autor1.Nome = "Rick";
            autor1.Email = "Rick@gmail.com";
            autor1.WhatsApp = "11923412321";


            Editora editora =  new Editora();

            editora.RazaoSocial = "Livros hihi";


            Livro livro = new Livro();
            livro.Editora = editora;

        }

    }
}
