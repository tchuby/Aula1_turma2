using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistraImoveis.Models
{
    public class MigrationContext : DbContext
    {
        public virtual DbSet<Titular> Titualres { get; set; }
        public virtual DbSet<BemImovel> Imoveis { get; set; }
    };
}