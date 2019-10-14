using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Controller;
using EntityLibrary.Model; 

namespace Alunos
{
    class Program
    {
        static AlunosController aluno = new AlunosController();
        static void Main(string[] args)
        {
            aluno.AddAluno( 
                new Aluno()
                {
                    Nome = "Asdrubal",
                    Idade = 13
                }); 
            aluno.GetAlunos() 
                .ToList<Aluno>() 
                .ForEach(x => Console.WriteLine(x.Nome)); 

            Console.ReadKey();
        }
    }
}
