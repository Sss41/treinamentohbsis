﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
   public class ControleUsuario
    {
        public bool Ativo { get; set; } = true;
        
        public int UsuarioCriacao { get; set; } = 0;
        public int UsuaarioAlteracao { get; set; } = 0;
        public DateTime Datacriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
