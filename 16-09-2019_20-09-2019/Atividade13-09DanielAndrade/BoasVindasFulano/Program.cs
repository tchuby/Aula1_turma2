using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasVindasFulano
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = string.Empty;
            
            ShowGreetings();

            if (AskToContinue() == 1)
            {
                nome = AskToName();
                Console.WriteLine($"Massa! {nome}, lembre-se que Raça Negra é melhor que Beatles!");
                Console.ReadKey();
            }

            else 
            {
                Console.WriteLine("Vai te catar!");
                Console.ReadKey();
            }                 
                        
        }

        
        /// <summary>
        /// Metodo para mostrar o texto inicial
        /// </summary>
        private static void ShowGreetings()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("-----Fala aê!-----");
            Console.WriteLine("------------------");
        }

        /// <summary>
        /// Metodo para realizar a pergunta que continua o dialogo
        /// </summary>
        /// <returns>retorna o valor que foi inserido.</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Beleza? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        /// <summary>
        /// Metodo para perguntar o nome.
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string AskToName()
        {
            Console.WriteLine("\r\nQual o seu nome completo?");
            return Console.ReadLine();
        }
    }

}
