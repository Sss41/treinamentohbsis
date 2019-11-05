using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiIMoveis.Model
{
    public  class Imovel
    {
        [Key]
        public int Id { get; set; }

        public int Cep { get; set; }

       
        public string Logradouro { get; set; }

       
        public string Bairrro { get; set; }

       
        public string Municipio { get; set; }

        public int Numero { get; set; }

      
        public string Complemento { get; set; }

        public int ProprietarioId { get; set; }
    }
}
