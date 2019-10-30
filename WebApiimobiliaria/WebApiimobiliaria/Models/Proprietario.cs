namespace WebApiimobiliaria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proprietario")]
    public partial class Proprietario
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        [StringLength(80)]
        public string Email { get; set; }
    }
}
