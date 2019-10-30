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
    public partial class VendasController
    {

        [HttpGet]
        [Route("Api/Carroes/Vendas")]
        public object CustomOnVendas()
        {
            var listMarcas = db.Vendas.ToList();

            var conteudoRetorno = from ven in listMarcas


                                  select new
                                  {
                                      VendasId = ven.Id,
                                      valor = ven.Quantidade
                                  };
            return conteudoRetorno;
        }

    }
}