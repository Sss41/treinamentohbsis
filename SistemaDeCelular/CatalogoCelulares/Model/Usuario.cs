using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Usuario : ControleUsuario
    {
        [Key]//definindo como primary key e identity(1,1)
        public   int   Id { get; set; }
        [MaxLength(50)]// delimita um tamanho maximo para o campo string
        public string Nome { get; set;}
        [MaxLength(30)]
        [Required]//definimos que este campo e obrigatorio(o usuario tem de passar a informação)
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }  
        
    }
}
