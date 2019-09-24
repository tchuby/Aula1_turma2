using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        /// <summary>
        /// propriedade que armazena id 
        /// </summary>
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;
        /// <summary>
        /// Metodo construtor que prepara nossa classe LocacaoContext
        /// </summary>
        public LocacaoContext()
        {
            //Criamos uma lista de livros em memoria
            ListaDeLivros = new List<Livro>();

            //Criamos uma nova lista de usuarios em memória
            ListaDeUsuarios = new List<Usuario>();

            //Adicionamos os livros
            ListaDeLivros.Add(new Livro()
            {
                Nome = "As aventuras de Tom Saweyr.",
                Id = IdContadorLivros++


            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Peter Pan.",
                Id = IdContadorLivros++

            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "As Aventuras de Pedrinho.",
                Id = IdContadorLivros++

            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Queda de Gigantes.",
                Id = IdContadorLivros++

            });

            //Adicionamos o usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin123",
                Senha = "123"
            });
        }
        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios {get; set; }

    }
}
