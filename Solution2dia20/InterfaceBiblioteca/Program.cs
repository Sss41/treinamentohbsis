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

        static LivrosController livrosController = new LivrosController();
        static UsuarioController usuarioController = new UsuarioController();

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
            var menuEscolhido = 1;
            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1- Listar usuário");
                Console.WriteLine("2- Cadastrar livros");
                Console.WriteLine("3- Listar livros");
                Console.WriteLine("4- Trocar usuário");
                Console.WriteLine("0- Sair");
                menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (menuEscolhido)
                {
                    case 1:
                        MostraUsuario();
                        break;
                    case 2:
                        AdicionarLivros();
                        break;
                    case 3:
                        MostraLivro();
                        break;
                    case 4:
                        RealizaLoginSistema();
                        Console.WriteLine("Login senha invalidos.");
                        MostraMenuSistema();
                        break;

                    default:
                        break;
                }

            }
        }


        public static void AdicionarLivros()
        {
            Console.WriteLine("Cadastrar livro dentro do sistema");
            Console.WriteLine("Nome do livro para cadastro");
            var nomeDoLivro = Console.ReadLine();

            livrosController.AdicionarLivro(new Livro()
            {
                Nome = nomeDoLivro
            });
            Console.WriteLine("livro cadastrado com sucesso");
            Console.ReadKey();
        }
        private static void MostraUsuario()
        {
            usuarioController.ListaUsuarios.ForEach(i =>
            Console.WriteLine(i.Login));
            Console.ReadKey();
        }

        private static void MostraLivro()
        {
            livrosController.Livros.ForEach(i =>
            Console.WriteLine(i.Nome));
            Console.ReadKey();
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
