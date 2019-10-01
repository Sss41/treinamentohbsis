using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
   public class CarroController
    {
        public SistemaCarroContext sistemaCarroContext = new SistemaCarroContext();
        /// <summary>
        /// Metodo que retorna sistema de carros
        /// </summary>
        /// <returns></returns>
        public List<Carro> Listar()
        {
            return sistemaCarroContext.ListaDeCarros;
        }
    }
}
