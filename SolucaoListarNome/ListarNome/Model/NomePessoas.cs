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
        public string Nome { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
