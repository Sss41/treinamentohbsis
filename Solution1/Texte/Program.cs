using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texte
{
    class Program
    {   
        static void Main(string[] args)
        {
           
            List<int> numeros = new List<int>();
            Random rdm = new Random();

            for(int w = 0; w < 10; w++)
            {
                int ValorGeradoAleatoriamente = rdm.Next(100);

                if (!numeros.Contains(ValorGeradoAleatoriamente))
                {
                    numeros.Add(ValorGeradoAleatoriamente);       
                }
                else
                {
                    w--;
                }
                Console.ReadKey();
            }
        }
    }
}
