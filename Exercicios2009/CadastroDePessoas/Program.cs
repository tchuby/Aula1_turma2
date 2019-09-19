using CadastroDePessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    class Program
    {

        static List<Pessoa> dadosPessoais = new List<Pessoa>();
        

        static void Main(string[] args)
        {

            Menu();

        }
        public static void Menu()
        {

            Console.WriteLine("Digite 1 para cadastrar pessoa.");
            
            var opcao = Console.ReadLine();

            while (opcao == "1")
            {
                AdicionarLista();
                Console.WriteLine("Para continuar cadastrando digite 1.");
                opcao = Console.ReadLine();
            }

            Listar();
                    

        }
        public static void AdicionarLista()
        {

            Pessoa individuo = new Pessoa();

            Console.WriteLine("Digite o nome:");
            individuo.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            individuo.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo, (M) ou (F):");
            individuo.Sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Altura:");
            individuo.Altura = double.Parse(Console.ReadLine());

            dadosPessoais.Add(individuo);

        }
        public static void Listar()
        {

            dadosPessoais.ForEach(i => Console.WriteLine($"Nome: {i.Nome};\r\n" +
               $"Idade: {i.Idade} anos;\r\n" +
               $"Sexo: {i.Sexo};\r\n" +
               $"Altura: {i.Altura}."));
            Console.ReadKey();

        }
    }
}
