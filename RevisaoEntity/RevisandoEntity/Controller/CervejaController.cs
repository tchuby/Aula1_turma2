using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    public class CervejaController
    {
        //Iniciamos nossa base de dados na controller
        CervejaContextDB contextDb = new CervejaContextDB();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDb.Cervejas.Add(item);
                contextDb.SaveChanges();
            }
            
        }
        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDb
                .Cervejas
                .Where(x => x.Nome.Contains("Cerveja")); 
        }
    }
}
