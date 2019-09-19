using AmigosFixo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosFixo
{
    class Program
    {
        static void Main(string[] args)
        {
            var amigos = new List<Amigos>();

            amigos.Add(new Amigos()
            {
                Name = "Asdrubal",
                Age = 12                

            });

            amigos.Add(new Amigos()
            {
                Name = "Anibal",
                Age = 17

            });

            amigos.Add(new Amigos()
            {
                Name = "Agamenom",
                Age = 13

            });

            amigos.ForEach(i => Console.WriteLine($"Amigo: {i.Name};\r\n" +
                $"Tempo de amizade: {i.Age} anos."));
            Console.ReadKey();


        }
    }
}
