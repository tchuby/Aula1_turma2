using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitandoForeachSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit();  
        }
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe seu nome:");
            
            var seunome = Console.ReadLine();

            var conteudoDoTexto = "Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";

            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit)
            {
                if (seunome == item)
                    Console.WriteLine("Troca com sucesso.");
            }
            Console.ReadKey();

        }
        

    }
}
