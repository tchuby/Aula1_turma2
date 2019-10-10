using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoNomes.Model;

namespace CatalogoNomes.Controller
{
    public class NomesController
    {
        NomesContextDB contextDB = new NomesContextDB();

        public IQueryable<Nome> ListaNomes()
        {
            return contextDB.Nomes;

        }
        public void InserirNomes(Nome nominho)
        {
                   
            contextDB.Nomes.Add(nominho);
            contextDB.SaveChanges();
        }
    }
}
