namespace CharmosaApp.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estruturaBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_ADMINISTRADOR",
                c => new
                    {
                        AdmistradorID = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.AdmistradorID);
            
            CreateTable(
                "dbo.TB_FUNCIONARIO",
                c => new
                    {
                        FuncionarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 250, unicode: false),
                        Sobrenome = c.String(maxLength: 250, unicode: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Login = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.FuncionarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_FUNCIONARIO");
            DropTable("dbo.TB_ADMINISTRADOR");
        }
    }
}
