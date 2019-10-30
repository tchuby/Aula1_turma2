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
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarroesController
    {
        [HttpGet]
        [Route("Api/Carroes/CustomQuery")]
        public object CustomCarrosQuerry()
        {
            var listaDeCarros = db.Carros.ToList();
            var retornoCarros = from cr in listaDeCarros
                                select new
                                {
                                    NomeCarro = cr.Modelo,
                                    CarroId = cr.Id
                                };
            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from marcas in listMarcas
                                  join car in listCarros
                                  on marcas.Id equals car.Marca
                                  select new
                                  {
                                      CorroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = marcas.Id,
                                      MarcaNome = marcas.Nome
                                  };
            return conteudoRetorno;

        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComUsuarios")]
        //public object CustomCarrosOnUsuarios(int IdCarro)
        public object CustomCarrosOnUsuarios(int IdCarro)
        {
            var listCarros = db.Carros.Where(p => p.Id == IdCarro).ToList();
            //var listCarros = db.Carros.ToList();
            var listUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from carros in listCarros
                                  join usuarios in listUsuarios
                                  on carros.UsuInc equals usuarios.Id

                                  select new
                                  {
                                      Carro_Id = carros.Id,
                                      Carro_Nome = carros.Modelo,
                                      Cadastrado_Por = usuarios.Usuario1
                                  };
            return conteudoRetorno;

        }
    }
}