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


        [HttpGet]
        [Route("Api/Carroes/VendasPorAno/{ano}")]
        public object CustomOnVendasPorAno(int ano)
        {
            var listMarcas = db.Vendas.ToList();

            var conteudoRetorno = from ven in listMarcas
                                  where (ven.DatInc).Year == ano

                                  select new
                                  {
                                      VendasId = ven.Id,
                                      data = ven.DatInc,
                                      modelo = ven.Quantidade,

                                  };


            return conteudoRetorno;
        }


        [HttpGet]
        [Route("Api/Carroes/Marcas/{ano}/{marca}")]
        public object CustomOnVendasMarcas(int ano,string marca) 
        {
            var listVendas = db.Vendas.ToList();
            var listUsuario = db.Usuarios.ToList();
            var listCarro = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();
            var conteudoRetorno = from ven in listVendas
                                  join usu in listUsuario
                                  on ven.UsuInc equals usu.Id
                                  join car in listCarro
                                  on ven.Carro equals car.Id
                                  join mar in listMarcas
                                  on car.Marca equals mar.Id
                                  where mar.Nome == marca
                                  where(ven.DatInc).Year == ano
                            select new
                              {
                                 VendasId = ven.Id,
                                 data = ven.DatInc,
                                 quantidade=ven.Quantidade,
                                 modelo= car.Modelo,
                                 usuario= usu.Usuario1

                              };


            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Carroes/VendasPorAnoComUsuario/{ano}/{nome}")]
        public object CustomOnVendasPorAnocomUsuario(int ano, string nome)
        {
            var listVendas = db.Vendas.ToList();
            var listUsuario = db.Usuarios.ToList();
            var listCarro = db.Carros.ToList();
            var conteudoRetorno = from ven in listVendas
                                  join usu in listUsuario
                                  on ven.UsuInc equals usu.Id
                                  join car in listCarro
                                  on ven.Carro equals car.Id

                                  where usu.Usuario1 == nome
                                  where (ven.DatInc).Year == ano

                                  select new
                                  {
                                      VendasId = ven.Id,
                                      data = ven.DatInc,
                                      quantidade = ven.Quantidade,
                                      modelo = car.Modelo,
                                      usuario = usu.Usuario1

                                  };


            return conteudoRetorno;
        }
    }
}