using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;


namespace InterfaceBiblioteca
{
    class Program
    {
        //Atualizado em 10/10/19
        //Instanciamos  os livros na memoria
        static LivrosController livros = new LivrosController();

        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();
        }
        /// <summary>
        /// Mostra no console o menu  disponivel do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {

            //Iniciamos nossa variavel com o menor valor de itn possivel
            var menuEscolhido = int.MinValue;

            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                //Mostra as opções de menu dentro do nosso sistema
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Cadastrar usuario");
                Console.WriteLine("5 - Remover usuario");
                Console.WriteLine("6 - Remover livro");
                Console.WriteLine("7 - Atualizar livro");
                Console.WriteLine("8 - Trocar de usuario");
                Console.WriteLine("0 - Sair");
                //Aqui vamos pegar numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        Console.Clear();
                        //Realiza a chamada do menu de listagm de usuarios
                        MostrarUsuarios();
                        break;
                    case 2:
                        Console.Clear();
                        //Realiza cadastro de livro 
                        ListarLivros();
                        break;
                    case 3:
                        Console.Clear();
                        //Realiza a chamada do menu de listagem de livros
                        AdicionarLivro();
                        break;
                    case 4:
                        Console.Clear();
                        //Realiza o cadastro de novo usuario
                        AdicionarUsuario();
                        break;
                    case 5:
                        Console.Clear();
                        //remove usuario
                        RemoverUsuarioPeloID();
                        break;
                    case 6:
                        Console.Clear();
                        //remove livro
                        RemoverLivroPeloID();
                        break;
                    case 7:
                        Console.Clear();
                        //Atualiza livro
                        AtualizarLivro();
                        break;
                    case 8:
                        Console.Clear();
                        //Altera usuario
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Metodo que remove o usuario pelo ID
        /// </summary>
        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover um Usuário pelo Id.");
            //Metodo que mostra os usuarios criados anteriormente para facilitar 
            MostrarUsuarios();
            Console.WriteLine("Informe o ID para desativar do sistema: ");
            var usuarioID = int.Parse(Console.ReadLine());

            //Aqui chamamos RemoverUsuarioPorID da nossa clase que controla os usuarios
            usuarioController.RemoverUsuarioPorId(usuarioID);
            Console.WriteLine("Usuario desativado com sucesso");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que remove o livro pelo ID
        /// </summary>
        private static void RemoverLivroPeloID()
        {

            Console.WriteLine("Remover um livro pelo Id.");
            //Metodo que mostra os livros criados anteriormente para facilitar 
            ListarLivros();
            Console.WriteLine("Informe o ID para desativar do sistema: ");
            var livroID = int.Parse(Console.ReadLine());

            //Aqui chamamos RemoverUsuarioPorID da nossa cclase que controla os usuarios
            
            Console.WriteLine("Livro desativado com sucesso");
            Console.ReadKey();

        }

        /// <summary>
        /// Metodo que adiciona dentro da nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            Console.WriteLine("--Adicionar livro");
            Console.WriteLine("Informe o nome do livro");
            var livro = Console.ReadLine();

        }

        //Atualizado em 10/10/19
        /// <summary>
        /// Metodo de interface que atualiza o nome do livro no sistema
        /// </summary>
        private static void AtualizarLivro()
        {
            Console.WriteLine("--Atualizar Livro--");
            ListarLivros();
            Console.WriteLine("Informe o Id para alteração de registro:");
            var livroId = int.Parse(Console.ReadLine());

            var livro = livros.GetLivros().FirstOrDefault(x => x.Id == livroId);
            if (livro == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("Informe o Nome do livro");
            //Obtemos o novo nome do livro
            livro.Nome = Console.ReadLine();

                       

            var resultado = livros //Nosa controller
                .AtualizarLivro(livro);//Metodo que permite salvar a alteração
            if (resultado)
                Console.WriteLine("Livro atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar o nome do livro.");

        }

        //Atualizado 10-10-19
        /// <summary>
        /// Metodo que lista todos os livros
        /// </summary>
        private static void ListarLivros()
        {
            Console.WriteLine("--Lista de Celulares--");

            livros.GetLivros().ToList<Livro>().ForEach(x => 
            Console.WriteLine($"Id: {x.Id} Nome: {x.Nome}"));

            
        }

        //Atualizar
        private static void MostrarUsuarios()
        {
            usuarioController.RestornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id {i.Id}; Login usuário:{i.Login}"));
            Console.ReadKey();
        }

        //Atualizar
        /// <summary>
        /// Metodo que realiza os procedimento complestos de login dentro do 
        /// sistema como solicitação de login e senha pelo console assim como a 
        /// respectivas validações que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados
        /// estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();


            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });


        }

        //Atualizar
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuário no sistema.");
            Console.WriteLine("Informe um login: ");
            var loginUsuario = Console.ReadLine();
            Console.WriteLine("Informe uma senha: ");
            var senhaUsuario = Console.ReadLine();


            usuarioController.AcidionarUsuario(new Usuario()
            {

                Login = loginUsuario,
                Senha = senhaUsuario               
                
            });
        }
    }
}
