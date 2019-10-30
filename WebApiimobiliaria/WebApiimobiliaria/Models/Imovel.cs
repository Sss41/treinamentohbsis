namespace WebApiimobiliaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Imovel")]
    public partial class Imovel
    {
        public int Id { get; set; }

        public int? Cep { get; set; }

        [StringLength(50)]
        public string Logradouro { get; set; }

        [StringLength(50)]
        public string Bairrro { get; set; }

        [StringLength(50)]
        public string Municipio { get; set; }

        public int? Numero { get; set; }

        [StringLength(50)]
        public string Complemento { get; set; }

        public int? ProprietarioId { get; set; }
    }
}
