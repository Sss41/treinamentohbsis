using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classee que contem os metodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        public List<Usuario> ListaUsuarios { get; set; }
        public UsuarioController()
        {
            ListaUsuarios = new List<Usuario>();
            ListaUsuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
            });

            ListaUsuarios.Add(new Usuario()
            {
                Login = "silvana",
                Senha = "123"
            });
        }

        /// <summary>
        /// Metodo que realiza login dentro do nosso sistema
        /// para realozar o login padrão use:
        /// -Login Admin
        /// -SenhaAdmin
        /// </summary>
        /// <param name="Usuário">passamos um objeto de nome Usuario como parametro</param>
        /// <returns>Retorna verdadeiro qunao existir usuário com este login e senha</returns>

        public bool LoginSistema(Usuario usuarios)
        {

            return ListaUsuarios.Exists(x =>
                x.Login == usuarios.Login
                && x.Senha == usuarios.Senha);
            //return (usuarios.Login == "Admin") && (usuarios.Senha == "Admin");

        }
      
        
    }
}
