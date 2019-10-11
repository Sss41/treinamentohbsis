using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFloricultura.Model
{
   public class Flores
    {
        [Key]
       

        public string Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }
        public bool Quantidade { get; set; } = true;
        public bool Ativo { get; set; } = true;
        public string UsuarioCriacao { get; set; }
        public string UsuarioAlteracao { get; set;}
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
