namespace Avaliacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Faixa_Id = c.Int(),
                        TipoDeAssociacao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faixas", t => t.Faixa_Id)
                .ForeignKey("dbo.TipoDeAssociacaos", t => t.TipoDeAssociacao_Id)
                .Index(t => t.Faixa_Id)
                .Index(t => t.TipoDeAssociacao_Id);
            
            CreateTable(
                "dbo.Faixas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Grau = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoDeAssociacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Periodo = c.Int(nullable: false),
                        Mensalidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alunoes", "TipoDeAssociacao_Id", "dbo.TipoDeAssociacaos");
            DropForeignKey("dbo.Alunoes", "Faixa_Id", "dbo.Faixas");
            DropIndex("dbo.Alunoes", new[] { "TipoDeAssociacao_Id" });
            DropIndex("dbo.Alunoes", new[] { "Faixa_Id" });
            DropTable("dbo.TipoDeAssociacaos");
            DropTable("dbo.Faixas");
            DropTable("dbo.Alunoes");
        }
    }
}
