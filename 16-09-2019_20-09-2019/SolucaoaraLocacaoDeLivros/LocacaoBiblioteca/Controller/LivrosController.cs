using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        LocacaoContextDB contextDB = new LocacaoContextDB();

        /// <summary>
        /// Metodo que retorna a lista de livros Ativos
        /// </summary>
        /// <returns></returns>
        public IQueryable<Livro> GetLivros()
        {
            return contextDB //Nosso Acesso ao banco de dados
                .Livros //Nossa tabela
                .Where //Filtro
                (x => x.Ativo == true); //Condição do filtro
        }

        public bool AtualizarLivro(Livro item)
        {

        }

                        
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista 
        /// </summary>
        /// <param name="parametroLivro">Informanções do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adiciona o livro a nossa lista
            parametroLivro.Id = contextDB.IdContadorLivros++;        
            
            contextDB.ListaDeLivros.Add(parametroLivro);

        }
        
        /// <summary>
        /// Metodo para desativar o registro de livro pelo id
        /// </summary>
        /// <param name="identificaID">Id do livro a desativar</param>
        public void RemoverLivroPorID(int identificaID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
           var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificaID);
            //tratamento do valor quando ele não encontrr um livro pelo id
            if (livro != null)
                livro.Ativo = false;
        }
            

    }
}
