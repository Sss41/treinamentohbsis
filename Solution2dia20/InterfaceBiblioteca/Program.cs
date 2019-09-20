using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {

        static LivrosController livros = new LivrosController();
        static UsuarioController

        static void Main(string[] args)

        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha invalidos.");

            MostraMenuSistema();
            Console.ReadKey();


        }
        private static void MostraMenuSistema()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("1-Listar usuário");
            Console.WriteLine("2- Listar livros");
            Console.WriteLine("3-Listar usuário");
            Console.WriteLine("Cadastrar Livros.");
            Console.WriteLine("4-Trocar usuário");
            Console.WriteLine("0- Sair");

            var menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
           
                switch (menuEscolhido)
                {
                    case 1:
                        Mostrausuarios();
                        break;
                    case 2:
                        MostraLivro();
                  break;
                         case 3: break;
                         Case 4:
                             while (RealizaLoginSistema())
                        break;

                        default:
                        break;
                }

        }

        private static void MostraLivro()
        {
            livros.Livros.ForEach(i =>
            Console.WriteLine(i.Nome));

        }



        /// <summary>
        /// Metodo qu e realiza os procedimentos completos de login dentro do 
        /// sistema como solicitação de login e senhs pelo comsole assim como as
        /// respectivas validações que o mesmo precisa para entrar no sistama
        /// </summary>
        /// <returns>Retorna verdadeiro quandpo o login e senha informados
        /// estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");


            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();
            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);


        }
    }

}
