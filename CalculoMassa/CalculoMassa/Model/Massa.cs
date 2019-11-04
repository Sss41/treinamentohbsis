using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoMassa.Model
{
    public class Massa
    {
        [Key]
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Densidade { get; set; }
        public double VolumeTotal { get; set; } 
    }
}
