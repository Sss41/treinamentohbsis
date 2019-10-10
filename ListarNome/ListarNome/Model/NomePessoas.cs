using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarNome.Model
{
    public class Nome
    {
        [Key]
        [MaxLength(30)]
        [Required]
        public string Id { get; set; }
        
        public string nome { get; set; }
    }
}
