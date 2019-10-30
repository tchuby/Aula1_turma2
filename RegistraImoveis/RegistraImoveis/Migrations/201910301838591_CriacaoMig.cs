namespace RegistraImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BemImovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.String(),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        TitularId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Titulars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Natal = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Titulars");
            DropTable("dbo.BemImovels");
        }
    }
}
