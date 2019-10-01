using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Model;

namespace ListagemDeCerveja.Controller
{
    
   public  class CervejaController
    {
        
        private SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();

        public List<Cerveja> ListaCerveja() 
        {   
            return sistemaCervejaContext.listaDeCerveja;
        }
        public void AdicionarCerveja(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContadorCerveja++;
            sistemaCervejaContext.listaDeCerveja.Add(cerveja);
        }
    }
}
