using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto.");
            var texto = Console.ReadLine();
            int quantidade = texto.Length;
            int letraa = 0;
            int letrae = 0;
            int letrai = 0;
            int letrao = 0;
            int letrau = 0;  
            int quantidadetotalcaracteres = 0;
            char caracteres1;
            for (int i = 0; i < quantidade; i++)
            {
                caracteres1 = texto[i];
                if (caracteres1 == 'a')
                {
                    letraa++;

                }
                else if (caracteres1 == 'e')
                {
                    letrae++;
                }
                else if (caracteres1 == 'i')
                {
                    letrai++;
                }
                else if (caracteres1 == 'o')
                {
                    letrao++;
                }
                else if (caracteres1 == 'u')
                {
                    letrau++;
                }
                if ((caracteres1 == 'a') || (caracteres1 == 'e') || (caracteres1 =='i') || (caracteres1 == 'o') || (caracteres1 == 'u'))
                {
                    quantidadetotalcaracteres++;
                }
            }
            Console.WriteLine($"Quntidade total de caracteres: a,e,i,o,u: {quantidadetotalcaracteres}");
            Console.WriteLine($"Quantidade de letras a: {letraa}");
            Console.WriteLine($"Quantidade de letras e: {letrae}");
            Console.WriteLine($"Quantidade de letras i: {letrai}");
            Console.WriteLine($"Quantidade de letras o: {letrao}");
            Console.WriteLine($"Quantidade de letras u: {letrau}");

            Console.ReadLine();
        }
    }
}
