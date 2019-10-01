using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaLaranja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase com a palavra banana!");
            var textContent = Console.ReadLine();
            Console.WriteLine(textContent.Replace("banana", "laranja"));
            Console.ReadKey();
        }
    }
}
