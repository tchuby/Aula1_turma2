using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;
using ListagemDeCervejas.Controller;

namespace TesteCerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            listarCerveja();
            somarValor();
            somarVolume();
            
            Console.ReadKey();


        }
        static void adicionarCerveja()
        {
            cervejaController.AdicionarCerveja();

        }
        static void listarCerveja()
        {
            cervejaController.GetCervejas().ForEach(i => Console.WriteLine($"ID:{i.Id}" +
               $"Nome: {i.Nome} " +
               $"Volume: {i.Litros} " +
               $"Teor Alcoólico: {i.Alcool} " +
               $"Preço: {i.Valor}"));

        }
        static void somarValor()
        {
            cervejaController.SomatorioValor();
            

        }
        static void somarVolume()
        {
            cervejaController.SomatorioVolume();
        }

    }
}
