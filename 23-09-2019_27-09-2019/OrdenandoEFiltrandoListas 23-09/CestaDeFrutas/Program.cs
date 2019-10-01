using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            //Vamos ao mercado
            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelha",
                Peso = 212

            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarela",
                Peso = 300
            });
            // Neste ponto ordenamos os valores de forma decrescente pelo nome
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"ID {i.Id} Nome: {i.Nome}"));

            Console.WriteLine("_______________________________________");

            //Aqui ordenamos os valores pelo id de forma crescente
            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"ID {i.Id} Nome: {i.Nome}"));

            Console.WriteLine("_______________________________________");

            //Aqui filtramos os registros maiores que 100g e ordenamos pelo nome
            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"ID {i.Id} Nome {i.Nome} Peso {i.Peso}"));

            Console.WriteLine("_______________________________________Filtro por peso");

            (from frutinha in cestaDeFrutas //cria um subconjunto chamado frutinha dentro do conjunto Frutas
                              where frutinha.Peso > 100 // filtra por peso os itens menores de 100g
                              select frutinha).ToList<Fruta>() // ecreve o novo subconjunto com os itens selecionados
                              .ForEach(i => Console.WriteLine($"Fruta selecionada{i.Nome}"));

            Console.WriteLine("_______________________________________Filtro por cores");

            //aqui criamos uma variavel que recebe o valor buscado
            var mostrandoFind = cestaDeFrutas.
                //aqui é feito o filtro das informações por uma "ou--> || <---" outra cor
                Find(x => x.Cor == "Amarela" || x.Cor == "Vermelha");
            
            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");


            //aqui criamos uma variavel que recebera a coleção que estamos buscando
            var mostrandoFindAll = cestaDeFrutas.
                //Find All com esta condição tras frutas de cor amarela ou vermelhas
                FindAll(x => x.Cor == "Amarela" || x.Cor == "Vermelha");

            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome{i.Nome}"));

            //Aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //Como agora ele não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");

            Console.WriteLine("_______________________________________Find com OrderBy");

            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome)
                .ToList<Fruta>()
                .Find(X => X.Cor == "Amarela" || X.Cor == "Vermelha");
            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");

            Console.ReadKey();
           
        }
    }
}
