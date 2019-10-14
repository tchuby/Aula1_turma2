using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoFlores.Controller;
using CatalogoFlores.Model;


namespace FloresVista
{
    class Program
    {
        static FloresController flores = new FloresController();
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("Esolha uma opçaõ do menu");
                Console.WriteLine("1 - Listar Flor");
                Console.WriteLine("2 - Inserir Flor na lista");
                Console.WriteLine("3 - Gerar Relatório");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirFlor();
                        break;

                    case 2:
                        //kkk;
                        break;

                    case 3:
                        //kkk;
                        break;

                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
            public static void InserirFlor()
            {
                Console.WriteLine("Insira o nome da flor");
                var nome = Console.ReadLine();

                Console.WriteLine("Insira a quantidade");
                var quantidade = int.Parse(Console.ReadLine());

            var resultado = flores.InserirFlores(new Flor()
            {
              
                    Nome = nome,
                    Quantidade = quantidade
               
            });
              
                if (resultado)
                    Console.WriteLine("Flor inserida com sucesso");
            
            }
        }
    }

