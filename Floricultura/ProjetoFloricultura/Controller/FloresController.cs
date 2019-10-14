using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFloricultura.Model;

namespace ProjetoFloricultura.Controller
{
    public class FloresController
    {
        public FloresContextDB contextDb = new FloresContextDB();
        public IQueryable<Flores> GetFlores()
        {
            return contextDb.Flores.Where(x => x.Ativo == true);

        }
    }


}
