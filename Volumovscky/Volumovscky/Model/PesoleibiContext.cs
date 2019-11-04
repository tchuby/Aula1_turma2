using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volumovscky.Model;

namespace Volumovscky.Model
{
    public class PesoleibiContext: DbContext
    {
        public PesoleibiContext(DbContextOptions<PesoleibiContext> options)
             : base(options)
        {

        }
        public DbSet<Peso> Pesos { get; set; }
    }
}
