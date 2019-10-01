using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    /// <summary>
    /// Modelo que constrói os atributos genéricos da Cervaja no SistemaDeCerveja
    /// </summary>
    public class Cerveja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Litros { get; set; }
        public double Alcool { get; set; }
        public double Valor { get; set; }
    }
}
