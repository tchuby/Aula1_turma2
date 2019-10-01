using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.MODEL
{
    public class SistemaCarrosContext
    {
        public List<Carro> ListaDeCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Tata", Modelo = "Nano", Ano = 2012, Cilindradas = 800, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 2, Marca = "Seat", Modelo = "Cordoba", Ano = 1999, Cilindradas = 1600, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 3, Marca = "Daewoo", Modelo = "Espero", Ano = 1997, Cilindradas = 2000, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 4, Marca = "Ssangyoung", Modelo = "Kyron", Ano = 2018, Cilindradas = 1700, Portas = 5 });
            ListaDeCarros.Add(new Carro() { Id = 5, Marca = "Towner", Modelo = "Asia", Ano = 1998, Cilindradas = 800, Portas = 3 });
            ListaDeCarros.Add(new Carro() { Id = 6, Marca = "VolksWagen", Modelo = "Corrado", Ano = 1991, Cilindradas = 1800, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 7, Marca = "Fiat", Modelo = "Coupe", Ano = 1996, Cilindradas = 2000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 8, Marca = "Opel", Modelo = "Tigra", Ano = 1998, Cilindradas = 1600, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 9, Marca = "VolksWagen", Modelo = "SP2", Ano = 1975, Cilindradas = 1700, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 10, Marca = "Santa Matilde", Modelo = "SM", Ano = 1984, Cilindradas = 4100, Portas = 2 });
        }
        
    }
}
