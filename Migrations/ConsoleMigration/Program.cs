using ConsoleMigration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMigration
{
    class Program
    {
        static MigrationContext db = new MigrationContext();
        static void Main(string[] args)
        {
            db.Usuarios.ToList().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
    }
}
