using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        //1- Colocar console app para startar o projeto
        //2- Adicionar referência CatalagoCelulares
        //3- Adicionar Entity em nosso projeto
        //4- Adicionar using ao nosso projeto Model, Controller
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimos uma opção de men inicial
            var opcao = int.MinValue;
            //Definimos que enquanto for diferente de 0
            //Ele continui o loop
            while (opcao !=0)
            {
                Console.WriteLine("Esolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("0 - Sair");
                // obtemos a opção escolhida pelo usuario
                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a opção
                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                //Colocamos true para informar que não deve aparecer na tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        //Inserir
        /// <summary>
        /// 
        /// </summary>
        public static void InserirCelular()
        {
            Console.WriteLine("--Inserir Celular--");
            Console.WriteLine("Informe o Marca do Celular");

            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");

            var preco = double.Parse(Console.ReadLine());

            //criamos uma variável para identificar sucesso ou erro
            var resultado = celulares //Nossa Controller pelo novo nome dela
                .InserirCelular(new Celular() //Um novo celular
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco

            });
            //Verificamos se o valor é verdadeiro ou falso
            if (resultado) //Caso verdade sucesso
                Console.WriteLine("Celular cadastrado com sucesso!");
            else //Caso false apresenta aviso
                Console.WriteLine("Erro ao cadastrar aparelho!");

        }
        //Atualizar
        //Remover
        //Listar

    }
}
