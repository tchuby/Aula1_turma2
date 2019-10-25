using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome de aplicação e o que ela faz
        /// </summary>
        /// <returns>Retorna o que nossa aplicação faz</returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }
        public string Get(int anoNascimento, string nomeUsuario = "Default")
        {            
            if ((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $"{nomeUsuario}, encha o caneco!";
            }
            else
            {
                return $"{nomeUsuario}, encha a mamadeira.";
            }
        }
    }
}
