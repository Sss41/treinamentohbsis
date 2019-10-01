using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basedados.Model
{
    public class Vendas
    {
        public class Venda
        {
            public string Id { get; set; }
            public string Carro { get; set; }
            public int Quantidade { get; set; }
            public double Valor { get; set; }
            public DateTime Data { get; set; }
        }
    }
}
