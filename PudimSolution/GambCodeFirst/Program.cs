using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;
using CodeFirstTeste.Controller;

namespace GambCodeFirst
{
    class Program
    {
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            cerveja.AddCerveja(new Cerveja() { Nome = "Stella Artois" });

            Console.ReadKey();
        }
    }
}
