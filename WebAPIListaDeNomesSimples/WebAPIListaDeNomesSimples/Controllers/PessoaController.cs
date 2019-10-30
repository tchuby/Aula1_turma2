using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIListaDeNomesSimples.Models;

namespace WebAPIListaDeNomesSimples.Controllers
{
    public class PessoaController : ApiController
    {
        List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa(){ Nome = "Eurídice", Idade=20},
            new Pessoa(){ Nome = "Agamenom", Idade=16},
            new Pessoa(){ Nome = "Asdrubal", Idade=26},
            new Pessoa(){ Nome = "Cibele", Idade=18},
            new Pessoa(){ Nome = "Dione", Idade=22},
            new Pessoa(){ Nome = "Aquiles", Idade=23},
            new Pessoa(){ Nome = "Jacinto", Idade=17},
            new Pessoa(){ Nome = "Orfeu", Idade=21},
            new Pessoa(){ Nome = "Jocasta", Idade=19},
            new Pessoa(){ Nome = "Guaraci", Idade=24},
        };
        public List<Pessoa> Get()
        {
            return Pessoas;
        }
        public Pessoa Post(Pessoa item)
        {
            Pessoas.Add(item);

            return item;
        }
    }
}
