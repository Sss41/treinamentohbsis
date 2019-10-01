using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivo();
            SomaBalasListaDeCriancas();
            Console.ReadKey();
        }
        private static void SomarInteiroPrimitivo()
        {

            // quando utilizamos"[]" em um tipo primitiva podemos criar uma colecção destes 
            //valores.
            int[] colecaoInteiros =
                //alocamos memoria para nossa coleção de valor e informamos
                //memoriaOcupadaInt *quantidadeInformada
                new int[5]
                // Aqui carregamos nossa coleção de valores
            { 1,2,3,4,5};

            //Aqui somamos os valores em nossa lista
            Console.WriteLine(colecaoInteiros.Sum());
            
        }

       
        /// <summary>
        /// Metod que soma valores em uma lista
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memória
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma crianla dentri da minha Lista
                new Crianca()
                {
                    Nome = "Joãzinho",
                    Balas = 9
                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };
            //Soma a quantidade de balas
            Console.WriteLine(criancas.Sum(x => x.Balas));


        }
    }
}
