using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivos();
            SomaInteirosLista();
            SomaBalasListadeCriancas();

            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo primitivo podemos criar uma coleção destes
            //valores
            int[] colecaoInteiros =
                //alocamos memoria para nossa coleção de valor e informamos
                //a quantidade de memoria que vamos ocupar
                //memoriaOcupadaInt * quantidadeInformada
                new int[5] 
            //aqui carregamos  nossa coleção de valores
            { 1,2,3,4,5 };

            Console.WriteLine(colecaoInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma todos os valores inscritos em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {// Nossa coleção de valores
                1,2,3,4,5
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }

        /// <summary>
        /// Metodo que soma a quantidade de balas das crianças 
        /// </summary>
        private static void SomaBalasListadeCriancas()
        {
            //Nossa lista de crianças dentro da minha lista
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova criança dentro da minha lista
                new Crianca()
                {
                    Nome = "Joãozinho",
                    Balas = 9
                },//virgula separa um objeto de outro dentro da lista

                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };

            Console.WriteLine("Quantidade total de balas das crianças.");
            Console.WriteLine(
                //soma a quantidade de balas
                criancas.Sum(x=> x.Balas));
        }
    }
}
