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
        private LocacaoContext contextDB = new LocacaoContext(); 

        public LivrosController()
        {
            

        }
        
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "insraniada" cria dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informanções do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adiciona o livro a nossa lista
            parametroLivro.Id = contextDB.IdContadorLivros++;        
            
            contextDB.ListaDeLivros.Add(parametroLivro);

        }
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
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
