using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _10_25_Ex1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoImcController : ApiController
    {   
        public string Post(Usuario usuario)
        {
            
            var imc = usuario.peso/(usuario.altura*usuario.altura); 
            return $"Olá {usuario.nomeUsuario}, seu IMC é {imc}, calculando de acordo com sua Altura:{usuario.altura} e Peso:{usuario.peso}.";
        }
    }
}
