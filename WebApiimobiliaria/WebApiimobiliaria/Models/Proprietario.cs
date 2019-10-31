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
        [CustomValidator]

        [StringLength(30)]
        public string Nome { get; set; }
        [CustomValidator]
        public DateTime? DataNascimento { get; set; }

        [StringLength(80)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
