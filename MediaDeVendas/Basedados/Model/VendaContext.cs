using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basedados.Model
{
   public class VendaContext
    {
        public List<Vendas> listaVendas = new List<Vendas>();

        public VendaContext()
        {
            listaVendas.Add(new Vendas() {
                
            });

        }
    }
}
