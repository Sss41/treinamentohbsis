using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicliWhile
{
    class Program
    {
        static void Main(string[] args)
        {



            ShowInitAppText();

            string nome = string.Empty;
            string idade = 0;

           while (AsktTContinue() ==1)

            {
             nome = AsKToName();
             idade= AsKToAge();
            }
            Console.WriteLine("Suas informações: Nome{nome} e sua {idade}");
            Console.ReadKey();
        }
            private static void ShowInitAppText()
            private static void AsKToAge()

        {     Console.WriteLine("--------------");
              Console.WriteLine("Qual sua idade?");
              Console.WriteLine("---------------");
            }
                Console.WriteLine("Qual sua idade: maoir de 18(1) menor(2)");
                int idade = int.Parse(Console.ReadLine());
                if(idade>= 18);
                
                else
                 
            
    }


}     
