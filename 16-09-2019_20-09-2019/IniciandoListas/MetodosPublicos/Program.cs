using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {

           

        }
        /// <summary>
        /// Metodo principal de inicialização do sistema
        /// </summary>
        public static void ConversorMonetarioSis()
        {

            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valora ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma moeda para a conversão:");
            Console.WriteLine("DOLAR, EURO, IENE, BTC");

            var moedaAlvoParaConverter = Console.ReadLine().ToUpper();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);
            Console.ReadKey();

        }
            
        /// <summary>
        /// Metodo que converte moeda em real para uma alvo especificado
        /// para converter digite os alvos:
        /// -"EURO"
        /// -"IENE"
        /// -"BTC"
        /// -"DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Moedda em valor Real</param>
        /// <param name="moedaAlvo">Alvo que a moeda será convertida</param>
        public static void ConvertMoeda(double minhaMoeda,string moedaAlvo)
        {
                       
            switch (moedaAlvo)
            {
                                
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimailEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataDecimalEmEuro(minhaMoeda));
                    break;
                case "IENE":
                    Console.WriteLine(FormataDecimalEmIens(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataDecimalEmBitcoins(minhaMoeda));
                    break;
                default:
                    break;
                    
            }
            
        }

        /// <summary>
        /// Metodo que converte meu numero em ral para dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna valor formatado em dolar</returns>
        private static string FormataNumeroDecimailEmDolar(double meuNumero)
        {

            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }

        /// <summary>
        /// Metodo que cnverte meu numero em Real para Euros
        /// </summary>
        /// <param name="meuNumero"> Meu numero em reais</param>
        /// <returns>Retorna vaolor formatado em Euro</returns>
        private static string FormataDecimalEmEuro(double meuNumero)
        {

            return (meuNumero / 4.81).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "Euro ");

        }


        /// <summary>
        /// Metodo que converte meu numero em Real para Iene
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna valor em Ienes</returns>
        private static string FormataDecimalEmIens(double meuNumero)
        {

            return (meuNumero / 0.0420).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));

        }

        /// <summary>
        /// Metodo que cnverte meu numero em Real para Bitcoins
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna valor em Bitcoins</returns>
        private static string FormataDecimalEmBitcoins(double meuNumero)
        {

            return (meuNumero / 42205.04).ToString("C7", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "BTC ");

        }

    }
}
