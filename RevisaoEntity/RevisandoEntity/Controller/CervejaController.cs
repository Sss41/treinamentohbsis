using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    public class CervejaController
    {
        static CervejaContextDb cerveja = new CervejaContextDb();
        public void  AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                cerveja.Cervejas.Add(item);
                cerveja.SaveChanges();
            }
           
        }
    }
}
