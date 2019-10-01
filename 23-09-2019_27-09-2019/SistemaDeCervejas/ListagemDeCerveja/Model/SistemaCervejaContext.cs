using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCerveja.Model
{
   public class SistemaCervejaContext
    {
        public int IdContadorCerveja { get; set; } = 1;
        public List<Cerveja> listaDeCerveja { get; set; }

        public SistemaCervejaContext()
        {
            listaDeCerveja = new List<Cerveja>();

 
            

            //listaDeCerveja = new List<Cerveja>();

            listaDeCerveja.Add(new Cerveja() {Id = IdContadorCerveja++, Nome = "Brhama",        Alcool = 10 , Litros = 00.6, Valor = 6.40 });
            listaDeCerveja.Add(new Cerveja() {Id  = IdContadorCerveja++, Nome = "Stela",          Alcool= 10,   Litros = 0.6, Valor = 5.00 });
            listaDeCerveja.Add(new Cerveja() {Id  = IdContadorCerveja++, Nome = "Corona",        Alcool = 4.5, Litros = 0.3, Valor = 8.00});
            listaDeCerveja.Add(new Cerveja() {Id  = IdContadorCerveja++, Nome = "Antartica",     Alcool = 7.5, Litros = 0.63, Valor =7.50 });
            listaDeCerveja.Add(new Cerveja() {Id  = IdContadorCerveja++, Nome = "Skol puro Malte",Alcool=10,    Litros= 100 , Valor=7.40 });
        }
     
      
        
    }
}
