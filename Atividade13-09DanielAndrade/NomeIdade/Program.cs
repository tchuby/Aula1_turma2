using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = string.Empty;
            int idade = 0;

            nome = AskName();
            idade = AskToAge(nome);
                        
            Console.WriteLine($"Suas informações: Nome {nome} e sua idade {idade}");
            Console.ReadKey();
        }

        private static string AskName()
        {
            Console.WriteLine("\r\nQual o seu nome completo?");
            return Console.ReadLine();
        }

        private static int AskToAge(string nome)
        {
            Console.WriteLine("Qual a tua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($" Parabéns {nome}, você já está na fase adulta.");
            else
                Console.WriteLine($" {nome}, aproveite tua juventude");

            return idade;

        }
    }
}
