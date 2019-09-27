using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace TestandoDllDoProf
{
    class Program
    {
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;
            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pasta");
                Console.Write("1 - Criar pasta em Meus Documentos");
                Console.Write("2 - Deletar pasta em Meus Documentos");
                Console.Write("3 - Listar pastas em Meus Documentos");
                Console.Write("4 - Sextou");
                Console.WriteLine("0 Sair");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Informe o nome da pasta:");
                        var nomeDaPasta = Console.ReadLine();
                        documents.CriarPastaMeusDocumentos(nomeDaPasta);
                        break;
                    case 2:
                        Console.WriteLine("Informe o nome da pasta:");
                        var nomeDaPastaD = Console.ReadLine();
                        documents.DeletarPastaMeusDocumentos(nomeDaPastaD, true);
                        break;
                    case 3:
                        //Obtemos uma lista com o nome das pastas no diretório Meus Documentos
                        documents.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                        break;
                    case 4:
                        new HoraDoShow();
                            break;


                }
                Console.ReadKey();
            }
            
            
            

            

        }
    }
}
