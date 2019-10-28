using CalculandoIdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoImcController : ApiController
    {
       
        public string Get(string Nome,double Peso,double Altura)
        {
            var imc = Peso / (Altura * Altura);
            return $"Olá {Nome} seu IMC está alto,{imc} e ele foi calculado de acordo com sua Altura:{Altura} e Peso:{Peso}, seu imc esta alto precisa cuidar da saúde";
        }

        public string  Post(Class1 parametro)
        {
            var imc = parametro.Peso/ (parametro.Altura*parametro.Altura);

            return $"Olá {parametro.Nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura:{parametro.Altura} e Peso:{parametro.Peso}";
        }
    }
}
