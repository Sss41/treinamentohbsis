using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarNome.Model
{
    public class NomePessoas
    {
        [Key]
        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }
       
        public bool Ativo { get; set; } = true;

        public static object InserirNomes(NomePessoas nomePessoas)
        {
            throw new NotImplementedException();
        }
    }
}
