using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantidadeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado pelo usuário.

            Console.WriteLine("Digite um texto para saber seu número de letras");
            var nomeLength = Console.ReadLine();
            Console.WriteLine($"A quantidade de letras do seu texto é: {nomeLength.Replace(" ", "").Length}");
            Console.ReadKey();

        }
    }
}
