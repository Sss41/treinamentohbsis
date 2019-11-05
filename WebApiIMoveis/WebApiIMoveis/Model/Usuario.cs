using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiIMoveis.Model
{
    public class Usuario
    {   
        
        public string NomeUsuario { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataLTERACAO { get; set; } = DateTime.Now;

    }
}
