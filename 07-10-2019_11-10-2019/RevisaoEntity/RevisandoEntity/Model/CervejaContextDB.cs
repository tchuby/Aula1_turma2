using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;// inserido a´pós o DbContext 

namespace RevisandoEntity.Model
{
    public class CervejaContextDB : DbContext //Herdamos a classe que constrói o banco de dados (DbContext instalado pelo Ctrl + ".")
    {
        //Definimos nossa tabela no banco de dados
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}
