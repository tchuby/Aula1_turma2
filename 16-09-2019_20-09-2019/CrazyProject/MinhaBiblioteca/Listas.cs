using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class Listas
    {
        /// <summary>
        /// Metodo que lista marcas de cervejarias
        /// </summary>
        public static void ListaDeCervejas()
        {

            //Goose Island, Hoegaarden, Leffe, Norteña, Walls

            var cervejas = new List<string>();

            cervejas.Add("Goose Island");
            cervejas.Add("Hoegaarden");
            cervejas.Add("Leffe");
            cervejas.Add("Norteña");
            cervejas.Add("Walls");

            cervejas.ForEach (i => Console.WriteLine(i));
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que lista marcas de fabricantes de carros
        /// </summary>
        public static void ListaDeCarros()
        {

            var marcaDeCarro = new List<string>();

            marcaDeCarro.Add("Gurgel");
            marcaDeCarro.Add("Puma");
            marcaDeCarro.Add("Santa Matilde");
            marcaDeCarro.Add("Miura");
            marcaDeCarro.Add("Romi-Isetta");
            marcaDeCarro.Add("Willys-Overland");

            marcaDeCarro.ForEach (i => Console.WriteLine(i));
            Console.ReadKey();

        }
    }
}
