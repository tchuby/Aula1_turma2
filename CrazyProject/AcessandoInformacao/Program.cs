using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca; 

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuSistema();
            
        }

        private static void MenuSistema()
        {

            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - Mostrar Lista de Cervejas");
            Console.WriteLine("4 - Mostrar Lista de Carros");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();

                    } break;
                case 2:
                    {
                        ImprimirArvore.Arvore();
                        MenuSistema();

                    } break;
                case 3:
                    {
                        Listas.ListaDeCervejas();
                        MenuSistema();

                    }
                    break;
                case 4:
                    {
                        Listas.ListaDeCarros();
                        MenuSistema();

                    }
                    break;
                case 5:
                    {

                        Console.WriteLine("Saindo");
                        return;

                    } break;
                default:
                    break; 
            }
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado:");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculoDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaAreaDoQUadrado(ladoQuadrado)}");
            Console.ReadKey();
        }
    }
}
