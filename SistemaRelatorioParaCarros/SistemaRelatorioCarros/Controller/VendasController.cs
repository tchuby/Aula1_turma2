using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
    
    public class VendasController
    {
        //Chamando a base de dados na controller
        SistemaVendasContext vendasContext = new SistemaVendasContext();

        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                return vendasContext.ListaVendasPublica
                    .FindAll(x=> x.Data.Month == mes);
        }

        
    }
}
