using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoNomes.Model
{
    public class NomesContextDB : DbContext
    {
        public DbSet<Nome> Nomes { get; set; }
    }
}
