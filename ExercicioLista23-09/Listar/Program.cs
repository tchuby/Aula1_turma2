using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model; 

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas
            //podemos agora listar e demais funcionalidades
            PessoaController pessoaController = 
                //Nesta parte ao iniciar em memorisa
                //Iniciamos o construtor
                new PessoaController();

            pessoaController.ListaDePessoasPublica
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista_Ordenada_Por_Nome");

            pessoaController
                .GetPessoasOrdenadaAsc()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista_Ordenada_Por_DataDecrescente");
            
            pessoaController
                .GetPessoasOrdenadaDescPelaDataNascimento()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista_Ordenada_Por_dindim");

            Console.WriteLine("Escreva o valor filtrado:");

            double valorFiltrar = double.Parse(Console.ReadLine());

            pessoaController.GetPessoasComMaisPilasNaCarteira(valorFiltrar).ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista_Ordenada_Por_Maiores_DE_18");

            pessoaController.GetPessoasComIdadeMaiorA().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista_Ordenada_Por_Menores_De_16");

            pessoaController.GetPessoasComIdadeMenorQue().ForEach(i => MostraInformacoes(i));

            Console.ReadKey();
            #region esconder meu código 

            /*var listaDePessoas = new List<Pessoa>();

            listaDePessoas.Add(new Pessoa()
            {

                Id = 0,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 1,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 2,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 3,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 4,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 5,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 6,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 7,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 8,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 9,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 10,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 11,
                Nome = "Garrett",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 12,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 13,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 14,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 15,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 16,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67

            });
            
            listaDePessoas.Add(new Pessoa()
            {

                Id = 17,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 18,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83

            });

            listaDePessoas.Add(new Pessoa()
            {

                Id = 19,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00


            });

            Console.WriteLine("Questão 1__________________________");
            Console.WriteLine("Por Nome\r\n");

            listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Nome: {i.Nome}"));

            Console.WriteLine("Por Data de Nascimento:\r\n");

            listaDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Nome: {i.Nome}, Natal: {i.DataNascimento.ToString("dd/MM/yyyy")}"));

            Console.WriteLine("Questão 2__________________________\r\n");

            var filtroCarteira = listaDePessoas.Where(x => x.Carteira > 500).OrderBy(x => x.Carteira);

            filtroCarteira.ToList<Pessoa>().ForEach(i => Console.WriteLine($"ID {i.Id} Nome {i.Nome} Dindim {i.Carteira}"));

            Console.WriteLine("Questão 3__________________________\r\n");


            Console.ReadKey();*/
            #endregion
        }
        /// <summary>
        /// Metodo para mostrar a informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao"></param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("---- {0,20} ----", nomeAcao));
        }
        /// <summary>
        /// Metodo que mostrano console formatado nosso objeto
        /// "Pessoa"
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Nosso template que apresenta as informações bonitinhas
            //o format usa {0} essa expressão para colocar de acordo com a ordem informada dos paramentrs
            string template = "Id {0,-3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}";

            //recebemos as informações bonitinhas com o string format
                string textoFormatado = 
                // string.format e usado para formatar as strings deixando nosso texto padrão apresentavel
                string.Format(
                    //nosso primeiro parametro é o template qu usamos
                    template,
                    //após informar o template, temos os parametros este metodo espera um array de parametros
                    //Podemos passar muito parametros nele
                    pessoa.Id,
                    pessoa.Nome,
                    pessoa.DataNascimento.ToShortDateString(),
                    pessoa.Carteira.ToString("C2"));

            Console.WriteLine(textoFormatado);
                              

        }


    }
}
