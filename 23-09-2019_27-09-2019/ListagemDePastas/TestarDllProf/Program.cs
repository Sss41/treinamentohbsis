using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;


namespace TestarDllProf
{
    class Program
    {
        static DocumentsAutoGenerate documentsAutoGenerate = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pasta a ser criada");
            documentsAutoGenerate.CriarPastaMeusDocumentos(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
