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
        //Instanciamos  os livros na memoria
        static LocacaoBiblioteca.Controller.LivrosController livrosController = new LocacaoBiblioteca.Controller.LivrosController();

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
                Console.WriteLine("7 - Trocar de usuario");
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
                        MostrarLivro();
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
            MostrarLivro();
            Console.WriteLine("Informe o ID para desativar do sistema: ");
            var livroID = int.Parse(Console.ReadLine());

            //Aqui chamamos RemoverUsuarioPorID da nossa cclase que controla os usuarios
            livrosController.RemoverLivroPorID(livroID);
            Console.WriteLine("Livro desativado com sucesso");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que adiciona dentro da nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar Livro dentrodo sistema");
            //Informamos que para dar ontinuidade ele dee informar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro:");
            //Obtemos esta informação do susuário
            var nomeDOLivro = Console.ReadLine();            
            

            //"livrosController" livros controle e nosso objeto em memoria
            //como adicionar um item a nossa lista de livros

            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui atribuimos o nome que demos ao livro na propriedade nome do nosso livro
                //co o sinal de apenas um"=" temos atribuição, passagem de valor
                Nome = nomeDOLivro,
                

            });
            //Indico que fnalizamos o porcesso de cadastro do livro, assim  usuário já sabe 
            //que o mesmo foi realizzado e sem erros
            Console.WriteLine("Livro cadastrado com sucesso");
            //ReadKey apenas para que ele visualize esta informação
            Console.ReadKey();
        }

        private static void MostrarLivro()
        {

            livrosController.RetornaListaDeLivros().ForEach(item => Console.WriteLine($"ID {item.Id}; Nome {item.Nome}"));

            Console.ReadKey();
        }
        private static void MostrarUsuarios()
        {
            usuarioController.RestornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id {i.Id}; Login usuário:{i.Login}"));
            Console.ReadKey();
        }

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
