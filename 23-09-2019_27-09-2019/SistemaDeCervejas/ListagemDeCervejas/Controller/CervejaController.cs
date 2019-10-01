using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();

        /// <summary>
        /// Metodo que retorna a lista completa informações da massa de dados.
        /// </summary>
        /// <returns>Retorna a lista da massa de dados</returns>
        public List<Cerveja> GetCervejas()
        {
            return sistemaCervejaContext.ListaDeCerveja;
        }
        /// <summary>
        /// Metodo que adiciona novo item a lista Cerveja
        /// </summary>
        /// <param name="cerveja"></param>
        public void AdicionarCerveja(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContador++;
            sistemaCervejaContext.ListaDeCerveja.Add(cerveja);

        }
        /// <summary>
        /// Metodo que retorna o somatório do valor dos itens da lista
        /// </summary>
        public double RetornaValorTotalCervejas()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Valor);
            //double somaValor = GetCervejas().Sum(i => i.Valor);
            //Console.WriteLine($"Valor total da lista: {somaValor}");
        }
        /// <summary>
        /// Metodo que retorna o somatório do volume de cervejas da lista
        /// </summary>
        public double RetornaValorTotalLitrosCerveja()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Valor);
            //double somaLitros = GetCervejas().Sum(i => i.Litros);
            //Console.WriteLine($"Volume total da lista:{somaLitros}");
        }

    }
}
