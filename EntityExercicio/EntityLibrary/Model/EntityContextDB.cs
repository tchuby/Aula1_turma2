using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityLibrary.Model
{
    public class EntityContextDB : DbContext
    {
        public DbSet<Aluno> ListaDeAlunos { get; set; }
    } 
   
}
