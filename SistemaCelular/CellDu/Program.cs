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
                Console.WriteLine("2 - Atualizar celular");
                Console.WriteLine("3 - Remover celular");
                Console.WriteLine("0 - Sair");
                // obtemos a opção escolhida pelo usuario
                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a opção
                switch (opcao)
                {
                    // Caso for 1 ele insere um novo registro de celular
                    case 1:
                        InserirCelular();
                        break;
                        //Caso opção dois ele atualiza um celular existente 
                    case 2:
                        AtualizarCelular();
                        break;
                        //Caso opção 3 remove-se o celular
                    case 3:
                        RemoverCelular();
                        break;
                        //Caso opção 4 listar
                    case 4:
                        ListarCelular();
                        break;
                    case 0:
                        //Informamos que estamos saindo do sistema
                        Console.WriteLine("Saindo do sistema..");
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
        /// <summary>
        /// 
        /// </summary>
        public static void AtualizarCelular()
        {
            Console.WriteLine("--Atualizar Celular--");

            ListarCelular();

            //Informamos ao usuario que ele precisa que ele precisa colocar o id para realizar a alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            var celularId = int.Parse(Console.ReadLine());

            //Obtemos do banco o item completo que será atualizado
            var celular = celulares //Banco de dados
                .GetCelulares() //Obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId);//regra para obter o celular
            //verificmos se o celular existe
            if (celular == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

             
            Console.WriteLine("Informe o Marca do Celular");
            //Obtemos a marca do aparelho
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo");
            //Obtemos o modelo do aparelho
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");
            //Obtemos o preço do aparelho
            celular.Preco = double.Parse(Console.ReadLine());

            
            var resultado = celulares //Nosa controller
                .AtualizarCelular(celular);//Metodo que atualiza o celular
            if (resultado)
                Console.WriteLine("Celular atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar o aparelho.");
        }
        //Remover
        /// <summary>
        /// 
        /// </summary>
        public static void RemoverCelular()
        {
            Console.WriteLine("--Remover Celular--");

            ListarCelular();

            //Informamos ao usuario que ele precisa que ele precisa colocar o id para realizar a alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            var celularId = int.Parse(Console.ReadLine());

            var resultado = celulares.RemoverCelular(celularId);

            if (resultado)
                Console.WriteLine("Celular removido com sucesso");
            else
                Console.WriteLine("Erro ao remover aparelho.");
        }
        //Listar
        /// <summary>
        /// 
        /// </summary>
        public static void ListarCelular()
        {
            Console.WriteLine("--Listar Celular--");

            //Listamos aqui para identificar o item que camos alterar
            celulares.GetCelulares() //Obtemos a lista de celilares
                .ToList<Celular>() // Convertemos para uma lista em memoria
                .ForEach(x => //Laço de repetição para mostrar cada celular
                //Mostramos no console nosso celular
                 Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));
        }


    }
}
