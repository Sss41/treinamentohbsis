namespace CodeFirstTeste.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cerveja
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public double Teor { get; set; }
    }
}
