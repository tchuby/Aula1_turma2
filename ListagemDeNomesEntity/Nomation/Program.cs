using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoNomes.Model;
using CatalogoNomes.Controller;

namespace Nomation
{
    class Program
    {
        static NomesController nomes = new NomesController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao !=0)
            {
                Console.WriteLine("Esolha uma opçaõ do menu");
                Console.WriteLine("1 - Listar Nomes");
                Console.WriteLine("2 - Inserir Nome na lista");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Listagem();
                        break;

                    case 2:
                        InserirNome();
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

        public static void InserirNome()
        {
            Console.WriteLine("Digite o novo nome a ser inserido na lista.");
                        var novoNome = Console.ReadLine();
            nomes.InserirNomes(new Nome()
            {
                Name = novoNome
            });
            
        }

        public static void Listagem()
        {
            Console.WriteLine("Lista de Nomes");
            nomes.ListaNomes().ToList<Nome>().ForEach(x => 
            Console.WriteLine($"Nome:{x.Name}"));
        }
    }
}
