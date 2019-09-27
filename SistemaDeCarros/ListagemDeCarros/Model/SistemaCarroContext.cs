using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
   public class SistemaCarroContext
    {
        public List<Carro> ListaDeCarros = new List<Carro>();
        /// <summary>
        /// Metodo que mstra lista de carros
        /// </summary>
        public SistemaCarroContext()
        {
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "fiat",Modelo="Palio",Ano= "1987"
                ,Cilindradas = 250, Portas = 4 });

            ListaDeCarros.Add(new Carro(){Id = 2,Marca =  "Peugeut",     Modelo = "206",   Ano = "1987", Cilindradas = 250,  Portas = 4});
            ListaDeCarros.Add(new Carro(){Id = 3,Marca =  "Wolksvagen",  Modelo = "Fusca", Ano = "1974", Cilindradas = 124,  Portas = 4});
            ListaDeCarros.Add(new Carro(){Id = 4, Marca = "Dhevrolet",  Modelo = "Corsa", Ano = "2007", Cilindradas = 1250, Portas = 4 });
            ListaDeCarros.Add(new Carro() {Id = 5,Marca = "Renault",    Modelo = "308",   Ano = "2015", Cilindradas = 2500, Portas = 4});
            ListaDeCarros.Add(new Carro(){Id = 6,Marca =  "Honda",       Modelo = "Civic", Ano = "2017", Cilindradas = 2250, Portas = 4});
            ListaDeCarros.Add(new Carro(){Id = 7,Marca =  "Geta",        Modelo = "207",   Ano = "2016", Cilindradas = 800,  Portas = 4});
            ListaDeCarros.Add(new Carro(){Id = 8,Marca =  "Camaro",      Modelo = "GT",    Ano = "2000" ,Cilindradas = 1250, Portas = 4});
            ListaDeCarros.Add(new Carro(){ Id= 9,Marca =  "Kombi",     Modelo = "78",    Ano = "1987", Cilindradas = 100,  Portas = 4 });
            ListaDeCarros.Add(new Carro(){Id = 10,Marca = "fiat",       Modelo = "Uno",   Ano = "1987", Cilindradas = 1250, Portas = 4}); 
            
        }
    }
}
