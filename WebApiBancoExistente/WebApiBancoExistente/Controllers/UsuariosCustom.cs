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
    public partial class UsuariosController
    {
        [HttpGet]
        [Route("Api/Usuarios/CustomQuery")]
        public object CustomMarcasQuerry()
        {
            var listaDeUsuarios = db.Usuarios.ToList();
            var retornoUsuarios = from cr in listaDeUsuarios
                                select new
                                {
                                    NomeUsuario = cr.Usuario1,
                                    UsuarioId = cr.Id
                                };
            return retornoUsuarios;
        }
    }
}