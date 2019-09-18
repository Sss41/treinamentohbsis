using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformandoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Nome");
            foreach(var item in listaDeInformacoes)
            {
                var opcoes = item.Split(',');
                var nome = opcoes[0].Split(':')[1];
                var idade = opcoes[1].Split(':')[1];

                if (int.Parse (idade) >=18)
                    Console.WriteLine($"Nome:{nome} é maoir de idae.");

             // else if(int.Parse(idade)<18)
               //     Console.WriteLine($"Nome:{nome} é menor de idade.");
            }

            Console.ReadKey();
        }
    }
}
