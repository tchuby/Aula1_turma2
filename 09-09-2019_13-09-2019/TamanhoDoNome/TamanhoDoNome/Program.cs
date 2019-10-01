using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanhoDoNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o Tamanho do Nome a ser calculado");
            var nomeLength = Console.ReadLine();

            Console.WriteLine($"0 tamanho deste nome é:{nomeLength.Replace(" ","").Length}");
            Console.ReadKey(); 
        }
    }
}
