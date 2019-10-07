using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController(); 
        static void Main(string[] args)
        {
            pessoa.AddPessoa( // Aqui utilizamos o metodo da controller para adicionar a pessoa em nssa lista
                new Pessoa()
            {
                Nome ="Felipe" // Novo registro
            }); // O método AddPessoa tem o SaveChanges que realiza a gravação das informações em nosso anco de dados
            pessoa.GetPessoas() //Obtemos a lista de Pessas
                .ToList<Pessoa>() // Convertems para uma lista de pessoas
                .ForEach(x => Console.WriteLine(x.Nome)); // Mostrmos em nosso Console

            Console.ReadKey();
        }
    }
}
