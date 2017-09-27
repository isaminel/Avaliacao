namespace Avaliacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertAluno : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes (Nome, Cpf, Faixa_Id, TipodeAssociacao_Id) VALUES ('Martim Castro Ribeiro', '158.778.735-04', 8, 17)");
            Sql("INSERT INTO Alunoes (Nome, Cpf, Faixa_Id, TipodeAssociacao_Id) VALUES ('Lucas Alves Melo', '916.749.332-74', 11, 19)");
            Sql("INSERT INTO Alunoes (Nome, Cpf, Faixa_Id, TipodeAssociacao_Id) VALUES ('Breno Castro Carvalho', '454.019.800-9', 9, 18)");
            Sql("INSERT INTO Alunoes (Nome, Cpf, Faixa_Id, TipodeAssociacao_Id) VALUES ('Laura Cardoso Rocha', '361.089.665-56', 13, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
