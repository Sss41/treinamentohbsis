using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente1.Models;

namespace WebApiBancoExistente1.Controllers
{
    public partial  class MarcasController
    {
        [HttpGet]
        [Route("Api/Carroes/CustomQuery")]
        public object CustomMarcasQuery()
        {
            var listMarcas = db.Carros.ToList();
            var retornoMarcas = from cr in listMarcas
                                select new
                                {
                                    NomeCarro = cr.Modelo,
                                    CarroId = cr.Id
                                };
            return retornoMarcas;
        }
        [HttpGet]
        [Route("Api/Carroes/Marcas")]
        public object CustomOnMarcas()
        {
            var listMarcas = db.Marcas.ToList();
            var conteudoRetorno = from mar in listMarcas


                                  select new
                                  {
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };
            return conteudoRetorno;
        }
    }
}