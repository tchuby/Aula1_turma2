using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmProjeto
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            DesenharArvore();
            Console.ReadKey();
                                                               
        }

        /// <summary>
        /// Metodo que desenha uma árvore no console
        /// </summary>
        public static void DesenharArvore()
        {

            Console.WriteLine("                 888                                   ");
            Console.WriteLine("               8888888         88                      ");
            Console.WriteLine("              888 888888      8888                     ");
            Console.WriteLine("               8888 888    88888  888888               ");
            Console.WriteLine("      888        88888       8888888 88                ");
            Console.WriteLine("    8888888    8888 888888      88888 88               ");
            Console.WriteLine("   8888 8888     888888    888888888888   888          ");
            Console.WriteLine("88888888888888               888 8888   88888888       ");
            Console.WriteLine("  8888  888 8888 8888888   888888888      888888       ");
            Console.WriteLine("    888888888     888 88 888888   8888888888           ");
            Console.WriteLine("     888888   \\     8888888888   8888888              ");
            Console.WriteLine("               \\        | |      //                   ");
            Console.WriteLine("             8888888 88888888    //                    ");
            Console.WriteLine("          88888 88888 888  88 88888                    ");
            Console.WriteLine("              888888  88888 88888                      ");
            Console.WriteLine("   88 888 88     888 888 8888 //        88888          ");
            Console.WriteLine("  8888 88 888_______\\   | | //   888 888 8888 888     ");
            Console.WriteLine("   88 88888 88 88----\\  | |//__8888888 8888 888 8 88  ");
            Console.WriteLine("      888 8           \\ |    ------88888888 88888     ");
            Console.WriteLine("                       |     |        88  888888       ");
            Console.WriteLine("                       |     |                         ");
            Console.WriteLine("                       |     |                         ");
            Console.WriteLine("                       |     |                         ");
            Console.WriteLine("                       |     |                         ");
            Console.WriteLine("                       |     |                         ");
            Console.WriteLine("                      /       |                        ");
            Console.WriteLine("                     /         |                       ");
            Console.WriteLine("--------------------/           |----------------------");
            

        }

        /// <summary>
        /// Metodo que calcula a área do quadrado
        /// </summary>
        static public void AreaDoQuadrado()
        {

            Console.WriteLine("Especifique o lado do quadrado para saber sua área:");
            double ladoDoQuadrado = double.Parse(Console.ReadLine());
            double areaDoQuadrado = ladoDoQuadrado * ladoDoQuadrado;
            Console.WriteLine($"A aréa do quadrado é de: {areaDoQuadrado}");
           
        }

        /// <summary>
        /// Metodo que lista marcas de cervejarias
        /// </summary>
        static public void ListaDeCervejas()
        {

            //Goose Island, Hoegaarden, Leffe, Norteña, Walls

            var cervejas = new List<string>();

            cervejas.Add("Goose Island");
            cervejas.Add("Hoegaarden");
            cervejas.Add("Leffe");
            cervejas.Add("Norteña");
            cervejas.Add("Walls");

        }

        /// <summary>
        /// Metodo que lista marcas de fabricantes de carros
        /// </summary>
        static public void ListaDeCarros()
        {

            var marcaDeCarro = new List<string>();

            marcaDeCarro.Add("Gurgel");
            marcaDeCarro.Add("Puma");
            marcaDeCarro.Add("Santa Matilde");
            marcaDeCarro.Add("Miura");
            marcaDeCarro.Add("Romi-Isetta");
            marcaDeCarro.Add("Willys-Overland");

        }

    }
}
