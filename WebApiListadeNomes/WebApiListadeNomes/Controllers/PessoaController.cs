using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiListadeNomes.Models;

namespace WebApiListadeNomes.Controllers
{
    public class PessoaController : ApiController
    {
        List<Pessoa> listaDePessoa = new List<Pessoa>()
        {
            new Pessoa(){ Nome = "Felipe",Idade=25},
            new Pessoa(){ Nome = "Suzana",Idade=18},
            new Pessoa(){ Nome = "Allan",Idade=30},
            new Pessoa(){ Nome = "Adriano",Idade=44},
            new Pessoa(){ Nome = "Pedro",Idade=22},
            new Pessoa(){ Nome = "Leonardo",Idade=23},
            new Pessoa(){ Nome = "João",Idade=17},
            new Pessoa(){ Nome = "Giomar",Idade=16},
            new Pessoa(){ Nome = "Boslilau",Idade=19},
            new Pessoa(){ Nome = "Juca",Idade=24},
        };
        public List<Pessoa> Get()
        {
            return listaDePessoa.OrderByDescending(x=>x.Idade).ToList();
        }
        public Pessoa Post(Pessoa nome)  
        {

            listaDePessoa.Add(nome);
            
            return nome;
        }
    }
}
