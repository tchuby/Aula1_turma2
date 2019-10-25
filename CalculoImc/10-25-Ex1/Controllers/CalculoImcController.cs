using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _10_25_Ex1.Controllers
{
    public class CalculoImcController : ApiController
    {   
        public string Get(double peso, double altura)
        {
            var imc = peso/(altura*altura); 
            return $"Olá Fulano, seu IMC é {imc}, calculando de acordo com sua Altura:{altura} e Peso:{peso}.";
        }
    }
}
