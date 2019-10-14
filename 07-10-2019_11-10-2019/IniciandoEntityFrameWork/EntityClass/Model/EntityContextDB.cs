using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : 
        DbContext //DbContext classe pronta que contem toos s processos de conexão com o banco de dados listagem das tabelas seleção das inomações 
    {
        public DbSet//palara reservada para o Entity que indica que vamos definir uma tabela do nosso banco de dados
            <Pessoa>//aqui definimos nossa tabela
            ListaDePessoas { get; set; } //nesta parte libramos nossa tabela para acessar
    }
}
