using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _10_31_Ex2_WebApi_InnerJoin.Models;

namespace _10_31_Ex2_WebApi_InnerJoin.Controllers
{
    [RoutePrefix("Api/Reports")]
    public class ReportsController : ApiController
    {
        DataBaseContext db = new DataBaseContext();
        [HttpGet]
        [Route("{Ano}")]
        public object RelVendasAno(int ano)
        {
            var listaVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listaCarros = db.Carros.ToList();
            var conteudoRetorno = from ven in listaVendas
                                  join car in listaCarros
                                  on ven.Carro equals car.Id
                                  select new
                                  {
                                      Id = ven.Id,
                                      Carro = car.Modelo,
                                      Valor = ven.Valor,
                                      Total = (ven.Quantidade * ven.Valor).ToString("N2")

                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("{Ano}/{Usuario}")]
        public object RelAnoUsuario(int ano, int usuario)
        {
            var listaUsuarios = db.Usuarios.ToList();
            var listaVendas = db.Vendas.Where(x => x.DatInc.Year == ano && x.UsuInc == usuario).ToList();
            var listaCarros = db.Carros.ToList();
            var retornoConteudo = from ven in listaVendas
                                  join car in listaCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaUsuarios
                                  on ven.UsuInc equals usu.Id
                                  select new
                                  {

                                  };                      
            /*
            var listVendas = db.Vendas.ToList();
            var conteudoRelatorio = from vendas in listVendas
                                    where vendas.DatInc.Year == ano
                                    select new
                                    {
                                        Venda = vendas.Id,
                                        Data = vendas.DatInc,
                                        Quantidade = vendas.Quantidade
                                    };*/
            return retornoConteudo;
        }

        [HttpGet]
        [Route("PorMarcas/{ano}/{marca}")]
        public object RelAnoMarca(int ano, int marca)
        {
            var listaVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listaCarro = db.Carros.Where(x => x.Marca == marca).ToList();
            var listaMarca = db.Marcas.ToList();
            var conteudoRetorno = from ven in listaVendas
                                  join car in listaCarro on ven.Carro equals car.Id
                                  join mar in listaMarca
                                  on car.Marca equals mar.Id
                                  group new { ven, car, mar }
                                  by new { ven.DatInc.Month, mar.Nome }
                                  into ingroup
                                  select new
                                  {
                                      PeriodoVenda = ingroup.Key.Month,
                                      MarcaVenda = ingroup.Key.Nome,
                                      ValorTotalVendas = ingroup.Sum(x => x.ven.Quantidade * x.ven.Valor)
                                  };
            return conteudoRetorno.OrderByDescending(x=> x.ValorTotalVendas);
        }
    }
}
