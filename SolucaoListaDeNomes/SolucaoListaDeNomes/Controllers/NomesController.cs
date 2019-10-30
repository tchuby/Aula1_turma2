using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SolucaoListaDeNomes.Models;

namespace SolucaoListaDeNomes.Controllers
{
    public class NomesController : ApiController
    {
        List<ObjectNome> listaObjeto = new List<ObjectNome>()
        {
            new ObjectNome(){ Nome = "Eurídice", Idade=20},
            new ObjectNome(){ Nome = "Agamenom", Idade=16},
            new ObjectNome(){ Nome = "Asdrubal", Idade=26},
            new ObjectNome(){ Nome = "Cibele", Idade=18},
            new ObjectNome(){ Nome = "Dione", Idade=22},
            new ObjectNome(){ Nome = "Aquiles", Idade=23},
            new ObjectNome(){ Nome = "Jacinto", Idade=17},
            new ObjectNome(){ Nome = "Orfeu", Idade=21},
            new ObjectNome(){ Nome = "Jocasta", Idade=19},
            new ObjectNome(){ Nome = "Guaraci", Idade=24},
        };
        public List<ObjectNome> Get()
        {
            return listaObjeto;
        }
        public List<ObjectNome> Post(ObjectNome values)
        {
            
        }
    }
}
