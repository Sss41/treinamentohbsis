using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdcontadorLivros { get; set; } = 1;
        public int IdcontadorUsuarios { get; set; } = 1;
        /// <summary>
        public LocacaoContext()
        {
           
                //criamos uma lista de livros em memoria
                ListaDeLivros = new List<Livro>();
               //criamos um lista de usuarios em memoria
                ListaDeUsuarios = new List<Usuario>();

                //Adicionamos os livros 
                ListaDeLivros.Add(new Livro()
                {
                    Id = IdcontadorLivros++,
                    //Informo apenas o nome do livro para adicionar
                    Nome = "Meu Primeiro Livro"
                });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdcontadorLivros++,
                //Informo apenas o nome do livro para adicionar
                Nome = "Meu Primeiro Livro"
            });

            ListaDeLivros.Add(new Livro()
                {
                    Id = IdcontadorLivros++,
                    Nome = ""
                });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdcontadorUsuarios++,
                Login = "Admin",
                Senha = "Admin"
            }) ;

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdcontadorUsuarios++,
                Login = "Admin",
                Senha = "123"
            });
        }

        public List<Livro> ListaDeLivros { get; set; }

        public List<Usuario> ListaDeUsuarios{ get; set; }
    }
}

