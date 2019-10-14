using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoFlores.Model;


namespace CatalogoFlores.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();
        /// <summary>
        /// Metodo que retorna a lista de flores do banco de dados
        /// </summary>
        /// <returns>Lista de flores</returns>
        public IQueryable<Flor> ListarFlores()
        {
            return contextDB.Flores;
        }

        public bool InserirFlores(Flor item)
        {
            contextDB.Flores.Add(item);
            contextDB.SaveChanges();
            return true;

        }
    }
}
