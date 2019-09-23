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
        private int IdContador = 1;
        
        public LivrosController()
        {
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Nome = "Meu primeiro livro.",
                Id = IdContador++

                
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Meu segundo livro.",
                Id = IdContador++
               
            });           

        }
        private List<Livro> ListaDeLivros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "insraniada" cria dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informanções do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = IdContador++;
            //Adiciona o livro a nossa lista
            ListaDeLivros.Add(parametroLivro);
            
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
            

    }
}
