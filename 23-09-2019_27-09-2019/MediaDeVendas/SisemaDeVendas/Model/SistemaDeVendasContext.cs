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
       
        public int IdcontadorCarro { get; set; } = 1;
       
        public SistemaDeVendasContext()
        {
            {

                //criamos uma lista de livros em memoria
                ListaDeCarro = new List<Vendas>();
               

                //Adicionamos os livros 
                ListaDeCarro.Add(new Vendas()
                {
                    Id = IdcontadorCarro++,
                    //Informo apenas o nome do livro para adicionar
                    Carro = ""
                }
               );

             
                
            }
        

            }

        public List<Vendas> ListaDeCarro { get; set; }

    }

}


   

