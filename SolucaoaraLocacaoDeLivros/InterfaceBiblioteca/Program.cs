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
        static LocacaoBiblioteca.Controller.LivrosController livro = new LocacaoBiblioteca.Controller.LivrosController();

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
                Console.WriteLine("4 - Trocar de usuario");
                Console.WriteLine("0 - Sair");
                //Aqui vamos pegar numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamada do menu de listagm de usuarios
                        MostrarUsuarios();
                        break;
                    case 2:
                        //Realiza a chamada do menu de listagem de livros
                        MostrarLivro();
                        break;
                    case 4:
                        Console.Clear();
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;
                    case 3: break;
                    default:
                        break;
                }
            }
        }

        private static void MostrarLivro()
        {

            livro.Livros.ForEach(item => Console.WriteLine($"Nome {item.Nome}"));
            Console.ReadKey();
        }
        private static void MostrarUsuarios()
        {
            usuarioController.ListaDeUsuarios.ForEach(i => Console.WriteLine($"Login usuário:{i.Login}"));
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

            UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
        }
    }
}
