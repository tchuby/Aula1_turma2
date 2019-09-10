using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro 
            //pelo número de registro do sistema
            Console.WriteLine("Informe o livro a ser consultado:");
            //Parte do código que recebe as informações 
            //de resgistro do livro e coloca na variável
            //numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizo a comparação das informações
            //do livro informado com o que tenho disponível
            //em estoque
            if (numeroDoLivro == "123456")
            {
                Console.WriteLine("Livro Indisponível");
                Console.ReadKey();
                //Finaliza o método
                return;
            }
               else
            {
                Console.WriteLine("Deseja Alocar o Livro? (1) sim (2)não");
                var resposta = Console.ReadLine();
                if(resposta == "1")
                {
                    Console.WriteLine("Livro Alocado");
                        Console.ReadKey();
                    return;
                }
            }

            


        }
    }
}
