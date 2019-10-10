﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;


namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext : DbContext

    {
        public DbSet<Livros> ListaDeLivros { get; set; }
        public int IdcontadorLivros { get; internal set; }
    }
}

