using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDePessoas = new List<Pessoa>();

            listaDePessoas.Add(new Pessoa()
            {

                Id = 0,
                Nome = "Spears",
                Natal = DateTime.Parse("07/11/2004"),
                Carteira = 846.96

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 1,
                Nome = "Swanson",
                Natal = DateTime.Parse("20/06/2003"),
                Carteira = 233.09

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 2,
                Nome = "Gay",
                Natal = DateTime.Parse("03/12/2001"),
                Carteira = 911.92

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 3,
                Nome = "Gregory",
                Natal = DateTime.Parse("02/01/2000"),
                Carteira = 469.01

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 4,
                Nome = "Olson",
                Natal = DateTime.Parse("18/07/2001"),
                Carteira = 261.90

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 5,
                Nome = "Garza",
                Natal = DateTime.Parse("01/04/2000"),
                Carteira = 360.41

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 6,
                Nome = "Sweet",
                Natal = DateTime.Parse("12/03/2003"),
                Carteira = 312.76

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 7,
                Nome = "Cline",
                Natal = DateTime.Parse("26/03/2002"),
                Carteira = 484.51

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 8,
                Nome = "Oliver",
                Natal = DateTime.Parse("05/07/2004"),
                Carteira = 513.76

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 9,
                Nome = "Vang",
                Natal = DateTime.Parse("10/07/2000"),
                Carteira = 271.05

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 10,
                Nome = "Maddox",
                Natal = DateTime.Parse("29/05/2004"),
                Carteira = 783.97

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 11,
                Nome = "Garrett",
                Natal = DateTime.Parse("03/06/2006"),
                Carteira = 154.11

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 12,
                Nome = "Mcintosh",
                Natal = DateTime.Parse("06/07/2006"),
                Carteira = 902.80

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 13,
                Nome = "Yang",
                Natal = DateTime.Parse("29/04/2005"),
                Carteira = 550.48

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 14,
                Nome = "Hendricks",
                Natal = DateTime.Parse("05/09/2003"),
                Carteira = 410.56

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 15,
                Nome = "Cain",
                Natal = DateTime.Parse("12/01/2002"),
                Carteira = 221.13

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 16,
                Nome = "Blackburn",
                Natal = DateTime.Parse("10/05/2000"),
                Carteira = 135.67

            });
            
            listaDePessoas.Add(new Pessoa()
            {

                Id = 17,
                Nome = "Howe",
                Natal = DateTime.Parse("27/09/2005"),
                Carteira = 360.14

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 18,
                Nome = "Pratt",
                Natal = DateTime.Parse("18/09/2000"),
                Carteira = 991.83

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 19,
                Nome = "Sherman",
                Natal = DateTime.Parse("20/02/2003"),
                Carteira = 667.00


            });

            Console.WriteLine("Questão 1__________________________");
            Console.WriteLine("Por Nome\r\n");

            listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Nome: {i.Nome}"));

            Console.WriteLine("Por Data de Nascimento:\r\n");

            listaDePessoas.OrderByDescending(x => x.Natal).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Nome: {i.Nome}, Natal: {i.Natal.ToString("dd/MM/yyyy")}"));

            Console.WriteLine("Questão 2__________________________\r\n");

            var filtroCarteira = listaDePessoas.Where(x => x.Carteira > 500).OrderBy(x => x.Carteira);

            filtroCarteira.ToList<Pessoa>().ForEach(i => Console.WriteLine($"ID {i.Id} Nome {i.Nome} Dindim {i.Carteira}"));

            Console.WriteLine("Questão 3__________________________\r\n");


            Console.ReadKey();
        }
        public List
        
    }
}
