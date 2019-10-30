namespace RegistraImoveis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistraImoveis.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistraImoveis.Models.MigrationContext context)
        {
            context.Titualres.AddOrUpdate(i => i.Nome, new Models.Titular()
            {
                Nome = "Guaraci",
                Natal = DateTime.Parse("28/02/1972"),
                Email = "guaraci@gmail.com"
            });
            context.SaveChanges();

            var titularId = context.Titualres.FirstOrDefault(x => x.Nome == "Guaraci").Id;

            context.Imoveis.AddOrUpdate(i => i.TitularId, new Models.BemImovel()
            {
                Cep = "89035-300",
                Logradouro = "Theodoro Holtrup",
                Bairro = "Vila Nova",
                Municipio = "Blumenau",
                Numero = 89,
                Complemento = "Apto 406",
                TitularId = titularId
            });
            context.SaveChanges();
        }
    }
}
