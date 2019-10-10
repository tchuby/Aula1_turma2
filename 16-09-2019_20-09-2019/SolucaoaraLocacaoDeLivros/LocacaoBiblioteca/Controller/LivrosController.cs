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

        //Atualizado em 10-10-19
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

        //Atualizado em 10-10-19
        /// <summary>
        /// Metodo que permite salvar as alterações do livro no banco de dados
        /// </summary>
        /// <param name="item">livro que vamos atualizar</param>
        /// <returns>Retorna verdadeiro caso o item exista</returns>
        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB // Banco de dados 
                .Livros// Lista de livros
                .FirstOrDefault(x => x.Id == item.Id);// Regra de Busca
            if (livro == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
                contextDB.SaveChanges();
            }            
            return true;

        }

        //Atualizar conferir               
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista 
        /// </summary>
        /// <param name="parametroLivro">Informanções do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adiciona o livro a nossa lista
            contextDB.Livros.Add(parametroLivro);
            //salvamos em nosso banco
            contextDB.SaveChanges();

        }
        
        //Atualizar conferir
        /// <summary>
        /// Metodo para desativar o registro de livro pelo id
        /// </summary>
        /// <param name="identificaID">Id do livro a desativar</param>
        public void RemoverLivroPorID(int identificaID)
        {
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == identificaID);
            contextDB.SaveChanges();

        }
            

    }
}
