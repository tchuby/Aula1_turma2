using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class CelularesContextDB ://definimos nossa herança
        DbContext //O que vamos Herdar
    {
        //Definimos nossa primeira tabela de usuarios no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }

        // Definimos nossa tabela de celulares
        public DbSet<Celular> Celulares { get; set; }
    }
}
