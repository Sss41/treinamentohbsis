using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisemaDeVendas.Model
{
    public class SistemaDeVendasContext
    {

        public int IdContadorCarros { get; set; } = 1;
       
        /// <summary>
        public LocacaoContext()
        {

            
            ListaDeCarros = new List<Carro>();


            
            ListaDeCarros.Add(new Carros()
            {
                Id = IdContadorCarros++,
                
                
            });

           


        }

        public List<Carros> ListaDeCArros { get; set; }

    }
}


   

