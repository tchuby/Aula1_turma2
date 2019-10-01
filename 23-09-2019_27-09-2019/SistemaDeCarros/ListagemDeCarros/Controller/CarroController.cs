using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.MODEL;

namespace ListagemDeCarros.Controller
{
    /// <summary>
    /// Metodo que retorna a lista de carros (SAITAMA ESPANCA GOKU!!!)
    /// </summary>
    public class CarroController
    {
        SistemaCarrosContext sistemaCarrosContext = new SistemaCarrosContext();
        public List<Carro> GetCarros()
        {
            return sistemaCarrosContext.ListaDeCarros; 
        }
    }
}
