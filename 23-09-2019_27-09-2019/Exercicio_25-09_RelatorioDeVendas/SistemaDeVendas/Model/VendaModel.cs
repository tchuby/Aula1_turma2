using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioVendas.Model
{
    public class VendaModel
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
