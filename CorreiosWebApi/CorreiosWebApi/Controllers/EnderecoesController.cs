﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecoesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Enderecoes
        public IQueryable<Endereco> GetEnderecos()
        {
            return db.Enderecos;
        }
        [HttpGet]
        [Route("Api/Enderecoes/{Bairro}/InfoByBairro")]
        public IQueryable<Endereco> EnderecoByBairro(string Bairro)
        {
            return db.Enderecos.Where(x => x.Bairro==Bairro);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{Logradouro}/InfoByLogradouro")]
        public IQueryable<Endereco> EnderecoByLogradouro(string Logradouro)
        {
            return db.Enderecos.Where(x => x.Logradouro == Logradouro);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{Cep}/InfoByCep")]
        public IQueryable<Endereco> EnderecoByCep(double Cep)
        {
            return db.Enderecos.Where(x => x.Cep == Cep);
        }


        [HttpGet]
        [Route("Api/Enderecoes/{UF}/InfoByUF")]
        public IQueryable<Endereco> EnderecoByUF(string UF)
        {
            return db.Enderecos.Where(x => x.UF == UF);
        }


        [HttpGet]
        [Route("Api/Enderecoes/{Complemento}/InfoByComplemento")]
        public IQueryable<Endereco> EnderecoByComplemento(string Complemento)
        {
            return db.Enderecos.Where(x => x.Complemento == Complemento);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{Municipio}/InfoByMunicipio")]
        public IQueryable<Endereco> EnderecoByMunicipio(string Municipio)
        {
            return db.Enderecos.Where(x => x.Municipio == Municipio);
        }

        // GET: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update realizado com sucesso");
        }
      
        // POST: api/Enderecoes
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecos.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecos.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecos.Count(e => e.Id == id) > 0;
        }
    }
}