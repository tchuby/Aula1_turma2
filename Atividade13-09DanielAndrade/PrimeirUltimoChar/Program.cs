using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirUltimoChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma palavra qualquer:");

            var text = Console.ReadLine();

            Console.WriteLine($"O primeiro caracter da palavra é:  {text[0]}");



            Console.WriteLine($"O último caracter da palavra é: {text[text.Length - 1]}");

            Console.ReadKey();
        }
    }
}
