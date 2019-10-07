using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Model; 

namespace EntityLibrary.Controller
{
    public class AlunosController
    {
        //Este novo objeto representa nosso banco de dados
        EntityContextDB contextDB = new EntityContextDB();
        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.ListaDeAlunos;
        }

        public void AddAluno(Aluno item)
        {
             //Adiciono meu aluno na minha lista em memoria
            contextDB.ListaDeAlunos.Add(item);
            //Salvo ess informação no banco de dados
            contextDB.SaveChanges();

        }
    }
}
