using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeDecimais();  

            Console.ReadKey();

        }

        /// <summary>
        /// Mostra Lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {

            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));
                        

        }

        /// <summary>
        /// Mostra lista e String definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));
            
           
            
        }

        /// <summary>
        /// Mostra meus números inteiros
        /// </summary>
        private static void ListaInt()
        {

            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(i => Console.WriteLine(i));

            

        }

        /// <summary>
        /// Mostra lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {

            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") +" "+ FormataNumeroDecimailEmDolar(meuDecimal) +" "+ FormataDecimalEmEuro(meuDecimal) +" "+ FormataDecimalEmIens(meuDecimal) +" "+ FormataDecimalEmBitcoins(meuDecimal))); 

        }

        /// <summary>
        /// Metodo que converte meu numero em ral para dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna valor formatado em dolar</returns>
        private static string FormataNumeroDecimailEmDolar(double meuNumero)
        {

            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture ("en-US")); 

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
