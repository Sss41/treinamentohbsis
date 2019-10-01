using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisemaDeVendas.Model
{
    class Vendas
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public float Valor { get; set; }
        public float Quantidade { get; set; }
        public DateTime Data { get; set; }
    }
}
