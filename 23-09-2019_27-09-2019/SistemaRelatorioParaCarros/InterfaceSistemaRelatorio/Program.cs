﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController(); 
        static void Main(string[] args)
        {
            MostraMenuRelatorio();

            //Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            //vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

            Console.ReadKey();
        }
        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de relatórios");
            Console.WriteLine("1 - Relatório por periodo mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            //obtemos as informações do mes
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            //passamos o mes na mesma função para obter as vendas
                            var listaDoperiodoEscolhido = vendasController.GetVendas(menuEscolhido);

                            //Aqui imprimimos as informações para os usuarios
                            listaDoperiodoEscolhido
                                .ForEach(x => ImprimeInformacoes(x));

                            var totalMes = vendasController.GetVendas(menuEscolhido)
                                //somamos todos os registros multiplicando as valor venda vezes a quantidade
                                .Sum(x => x.Valor * x.Quantidade);
                            var mediaPeriodo = listaDoperiodoEscolhido
                                .Average(x => x.Valor * x.Quantidade);

                            //Mostramos o mes escolhido e o valor total neste mes gerado
                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");

                            //Mostramos o mes escolhido e o valor médio de vendas no mes gerado
                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");
                            
                            Console.ReadKey();
                        } break;
                }
            }
                
        }
        public static void ImprimeInformacoes(Venda vendas)
        {

            Console.WriteLine(string.Format("ID {0,3} Carro {1,-35} Valor {2,-10} Quantidade {3,3} Data {4,12}", 
                vendas.Id,
                vendas.Carro,
                vendas.Valor.ToString("C"),
                vendas.Quantidade,
                vendas.Data.ToShortDateString()));
                        
        }
    }
}
