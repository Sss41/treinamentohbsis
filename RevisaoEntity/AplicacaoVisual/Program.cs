using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;

namespace AplicacaoVisual
{
    class Program
    {

        //1- setar a a aplicação visua para startar o projeto
        //2- Vamos adicionar o EntityFramework ao nosso 
        //3- Colocar em nosso using o System.Data.Entity    
        //4-adicionar referencia da nossa ClassLibrary
        static CervejaContextDb cerveja = new CervejaContextDb();
        static void Main(string[] args)
        {
            cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
    }
}
