using MinhaTerceiraClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaTerceiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigos = new List<Amigos>();
           
            listaAmigos.Add(new Amigos()
            {
                Nome = " Rodrigo",
                TempoDeAmizade = 18
            });

            listaAmigos.Add(new Amigos()
            {
                Nome = " Sara",
                TempoDeAmizade = 36
            });
            listaAmigos.Add(new Amigos()
            {
                Nome = " Izabel",
                TempoDeAmizade = 25
            });

            listaAmigos.ForEach(i =>
            Console.WriteLine($"Nome:{ i.Nome} : TEmpo de Amizade{i.TempoDeAmizade}"));
            Console.ReadKey();
        }
    }
}
