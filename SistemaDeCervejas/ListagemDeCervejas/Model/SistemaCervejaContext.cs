using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    /// <summary>
    /// Lista que carrega a massa de dados so SistemaDeCervejas 
    /// </summary>
    public class SistemaCervejaContext
    {
        public int IdContador = 1;
        /// <summary>
        /// Metodo construtor da lista
        /// </summary>
        public List<Cerveja> ListaDeCerveja { get; set; }

        /// <summary>
        /// Massa de dados da lista Cerveja
        /// </summary>
        public SistemaCervejaContext()
        {
            //o new carrega a lista em memória para carregar as informações
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Antártica Original", Litros = 0.6, Alcool = 4.9, Valor = 5.49 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Polar", Litros = 1, Alcool = 5.1, Valor = 8.30 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Stella Artois", Litros = 0.275, Alcool = 5, Valor = 2.98 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Walls 42", Litros = 0.375, Alcool = 6.5, Valor = 19.90 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Franziskaner Hell", Litros = 0.5, Alcool = 5, Valor = 19.90 });
           
        }
        




    }
}
