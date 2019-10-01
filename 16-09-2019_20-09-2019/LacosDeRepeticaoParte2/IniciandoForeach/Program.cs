using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar sobre um array de caracteres, ou seja, um texto de palavras etc...
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;

                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo de busca com split e informandoo nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe o seunome:");

            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split('u');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                {
                    Console.WriteLine("palavra cencontrada com sucesso!");
                    break;
                }

            }
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que utiliza o split para mostrar itens de uma.
        /// </summary>
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);                
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }

            Console.ReadKey();
        }

        private static void ConsultaCarros()
        {
            //Base de informações
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaDeInfromacoes = conteudo.Split(';');

            Console.WriteLine("Carros presentes no sistema");

            foreach (var item in listaDeInfromacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um carro do sistema");
            var carroBusca = Console.ReadLine();

            foreach (var item in listaDeInfromacoes)
            {
                var informacoesSplit = item.Split(',');

                var modelo = informacoesSplit[0].Split(':')[1];
                var marca = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];

                if (modelo == carroBusca)
                {
                    Console.WriteLine($"O {modelo} é da marca {marca} e do ano {ano}.");
                }
            }
            
            Console.ReadKey();
        }

        private static void ListaValoresMaiorIdade()
        {


            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listDeConteudo = conteudo.Split(';');

            foreach (var item in listDeConteudo)
            {

                var quebraInformacao = item.Split(',');
                var idade = int.Parse(quebraInformacao[1].Split(':')[1]);
                var nome = quebraInformacao[0].Split(':')[1];

                if(int idade >= 18)
                    {


              
                    }
                  
                    
            }


        }
    }
}
