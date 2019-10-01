using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_teste
{
    class Program
    {
        //Iniciando uma constante de um número inteiro
        const int testeConst = 999;

        static void Main(string[] args)
        {
            string testePrimitivo = string.Empty;
            String outroTestePrimitivo = string.Empty;
            bool testComp = "123" == "123";
            Boolean testeComp = "123" == "123";

            bool? testeBoolNull;

            int numeroInteiro = 999;
            long numeroInteiroLongo = 8598215;

            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "String"; //Texto
            var teste2 = 'C'; //Char
            var teste3 = 0; //Int
            var teste4 = 0.0; //Double
            var teste5 = 0x00; //Hex
            //Apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();
                         
        }
    }
}
