using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNetCore.Model;

namespace WebApiNetCore.Model
{
    public class WebApiContext: DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
            : base(options)
        {
            
        }
        public DbSet<Bicicleta> Bicicletas { get; set; }
    }
}
