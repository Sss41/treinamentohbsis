using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()
             {
                "Felipe",
                "Irineu",
                "Serilop"
            };
    static void Main(string[] args)
    {
        AdicionarItensALista();
            ListaInformacoes();
        Console.ReadKey();
        //<summary> metodo que adiciona um item a lista
       
    }
          
   
        private static void AdicionarItensALista()
        {
            Console.WriteLine("Informe um nome");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Deseja informar mais valores? sim(S) não(N)");

            if (Console.ReadKey().KeyChar.ToString() == "S")
                AdicionarItensALista();
        }
            private static void ListaInformacoes()
            {
                Console.Clear();
                Console.WriteLine(  "Nomes adicionados a Lista");
                foreach (var item in minhaListaPulgmatica)
                    Console.WriteLine($"Noime: {item} foi adicionado a lista");
            }
          
      
    }
}
